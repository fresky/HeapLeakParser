using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeapLeakParser
{
    public sealed partial class HeapLeakParser : Form
    {

        private static readonly Regex s_LeakHeader = new Regex(@"^[0-9a-f]{8}[ ]+([0-9a-f]{8})[ ]+[0-9a-f]{8}[ ]+[0-9a-f]{8}[ ]+([0-9a-f]*)");
        private static readonly Regex s_CallStack = new Regex(@"^[\t]{2}[0-9a-f]{8}: ((.)*)");
        
        //private const string s_StackTrace = "stack_trace";
        //private const string s_HeapLeakStart = "Entry     User      Heap      Segment       Size  PrevSize  Unused    Flags";

        private List<Leak> m_Leaks = new List<Leak>();
        private int m_Total;
        private int m_Totalsize;

        public HeapLeakParser()
        {
            InitializeComponent();
            listBox_Leaks.SelectedIndexChanged += listBox_Leaks_SelectedIndexChanged;

            AllowDrop = true;
            DragEnter += HeapLeakParser_DragEnter;
            DragDrop += HeapLeakParser_DragDrop;
        }

        void HeapLeakParser_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void HeapLeakParser_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
                textBox_WindbgLogPath.Text = files[0];
        }

        void listBox_Leaks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Leak leak = listBox_Leaks.SelectedItem as Leak;
            if (leak != null)
            {
                textBox_CallStack.Text = leak.CallStack;
            }
            
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_WindbgLogPath.Text = dialog.FileName;
            }
        }

        private async void button_ParseHeapLeak_Click(object sender, EventArgs e)
        {
            string logPath = textBox_WindbgLogPath.Text;
            if (!File.Exists(logPath))
            {
                MessageBox.Show("Please specify the windbg log file!", "Error!");
                return;
            }
            m_Leaks.Clear();
            listBox_Leaks.Items.Clear();
            m_Leaks = await Task<List<Leak>>.Factory.StartNew(() =>
            {
                List<Leak> leaks = new List<Leak>();
                Leak currentLeak = null;
                using (StreamReader sr = new StreamReader(logPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        Match leakMatch = s_LeakHeader.Match(line);
                        if (leakMatch.Success)
                        {
                            if(currentLeak != null)
                                addNewLeak(leaks, currentLeak);
                            currentLeak = new Leak(leakMatch.Groups[1].ToString(),leakMatch.Groups[2].ToString());
                            continue;
                        }

                        Match stackMatch = s_CallStack.Match(line);
                        if (stackMatch.Success && currentLeak != null)
                        {
                            currentLeak.AppendCallStack(stackMatch.Groups[1].ToString());
                        }

                    }
                }
                addNewLeak(leaks, currentLeak);
                return leaks;
            });
            textBox_Total.Text = m_Total.ToString("#,###0");
            textBox_TotalSize.Text = m_Totalsize.ToString("#,###0");
            m_Leaks.Sort(Leak.CompareByTotalSize);
            listBox_Leaks.Items.AddRange(m_Leaks.ToArray());
        }

        private void addNewLeak(List<Leak> leaks, Leak currentLeak)
        {
            m_Total += 1;
            m_Totalsize += currentLeak.TotalSize;
            bool found = false;
            foreach (var leak in leaks)
            {
                if (!string.IsNullOrEmpty(leak.CallStack) && leak.CallStack.Equals(currentLeak.CallStack))
                {
                    found = true;
                    leak.AddCount();
                }
            }
            if(!found)
                leaks.Add(currentLeak);
        }


        private void button_Report_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName))
                {
                    sw.WriteLine("Leaks report!");
                    sw.WriteLine("Total Count: {0}, Total Size: {1}!", m_Total.ToString("#,###0"), m_Totalsize.ToString("#,###0"));
                    
                    foreach (var leak in m_Leaks)
                    {
                        sw.WriteLine("------------------------------------------------------------------------");
                        sw.WriteLine("|     Pointer      |       Size      |       Count       |       Total Size      |");
                        sw.WriteLine(leak);
                        sw.WriteLine("Call Stack:");
                        sw.WriteLine(leak.CallStack);
                    }
                }
            }
        }

        private void button_Size_Click(object sender, EventArgs e)
        {
            textBox_CallStack.Text = string.Empty;
            m_Leaks.Sort(Leak.CompareBySize);
            listBox_Leaks.Items.Clear();
            listBox_Leaks.Items.AddRange(m_Leaks.ToArray());
        }

        private void button_Count_Click(object sender, EventArgs e)
        {
            textBox_CallStack.Text = string.Empty;
            m_Leaks.Sort(Leak.CompareByCount);
            listBox_Leaks.Items.Clear();
            listBox_Leaks.Items.AddRange(m_Leaks.ToArray());
        }

        private void button_TotalSize_Click(object sender, EventArgs e)
        {
            textBox_CallStack.Text = string.Empty;
            m_Leaks.Sort(Leak.CompareByTotalSize);
            listBox_Leaks.Items.Clear();
            listBox_Leaks.Items.AddRange(m_Leaks.ToArray());
        }
    }
}
