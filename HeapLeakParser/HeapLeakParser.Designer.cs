namespace HeapLeakParser
{
    sealed partial class HeapLeakParser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ParseHeapLeak = new System.Windows.Forms.Button();
            this.textBox_WindbgLogPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.button_Report = new System.Windows.Forms.Button();
            this.listBox_Leaks = new System.Windows.Forms.ListBox();
            this.textBox_CallStack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TotalSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Size = new System.Windows.Forms.Button();
            this.button_Count = new System.Windows.Forms.Button();
            this.button_TotalSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ParseHeapLeak
            // 
            this.button_ParseHeapLeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ParseHeapLeak.Location = new System.Drawing.Point(673, 4);
            this.button_ParseHeapLeak.Name = "button_ParseHeapLeak";
            this.button_ParseHeapLeak.Size = new System.Drawing.Size(99, 23);
            this.button_ParseHeapLeak.TabIndex = 0;
            this.button_ParseHeapLeak.Text = "Parse Heap Leak";
            this.button_ParseHeapLeak.UseVisualStyleBackColor = true;
            this.button_ParseHeapLeak.Click += new System.EventHandler(this.button_ParseHeapLeak_Click);
            // 
            // textBox_WindbgLogPath
            // 
            this.textBox_WindbgLogPath.Location = new System.Drawing.Point(86, 6);
            this.textBox_WindbgLogPath.Name = "textBox_WindbgLogPath";
            this.textBox_WindbgLogPath.Size = new System.Drawing.Size(556, 20);
            this.textBox_WindbgLogPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Windbg Log:";
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(644, 4);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(23, 23);
            this.button_OpenFile.TabIndex = 3;
            this.button_OpenFile.Text = "...";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // button_Report
            // 
            this.button_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Report.Location = new System.Drawing.Point(673, 33);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(99, 23);
            this.button_Report.TabIndex = 4;
            this.button_Report.Text = "Generate Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // listBox_Leaks
            // 
            this.listBox_Leaks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Leaks.FormattingEnabled = true;
            this.listBox_Leaks.Location = new System.Drawing.Point(15, 91);
            this.listBox_Leaks.Name = "listBox_Leaks";
            this.listBox_Leaks.Size = new System.Drawing.Size(298, 459);
            this.listBox_Leaks.TabIndex = 5;
            // 
            // textBox_CallStack
            // 
            this.textBox_CallStack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CallStack.Location = new System.Drawing.Point(319, 91);
            this.textBox_CallStack.Multiline = true;
            this.textBox_CallStack.Name = "textBox_CallStack";
            this.textBox_CallStack.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_CallStack.Size = new System.Drawing.Size(453, 459);
            this.textBox_CallStack.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Call Stack:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Count:";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(86, 35);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(58, 20);
            this.textBox_Total.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Size:";
            // 
            // textBox_TotalSize
            // 
            this.textBox_TotalSize.Location = new System.Drawing.Point(213, 35);
            this.textBox_TotalSize.Name = "textBox_TotalSize";
            this.textBox_TotalSize.Size = new System.Drawing.Size(100, 20);
            this.textBox_TotalSize.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pointer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Size
            // 
            this.button_Size.Location = new System.Drawing.Point(86, 62);
            this.button_Size.Name = "button_Size";
            this.button_Size.Size = new System.Drawing.Size(58, 23);
            this.button_Size.TabIndex = 15;
            this.button_Size.Text = "Size";
            this.button_Size.UseVisualStyleBackColor = true;
            this.button_Size.Click += new System.EventHandler(this.button_Size_Click);
            // 
            // button_Count
            // 
            this.button_Count.Location = new System.Drawing.Point(153, 62);
            this.button_Count.Name = "button_Count";
            this.button_Count.Size = new System.Drawing.Size(75, 23);
            this.button_Count.TabIndex = 16;
            this.button_Count.Text = "Count";
            this.button_Count.UseVisualStyleBackColor = true;
            this.button_Count.Click += new System.EventHandler(this.button_Count_Click);
            // 
            // button_TotalSize
            // 
            this.button_TotalSize.Location = new System.Drawing.Point(238, 62);
            this.button_TotalSize.Name = "button_TotalSize";
            this.button_TotalSize.Size = new System.Drawing.Size(75, 23);
            this.button_TotalSize.TabIndex = 17;
            this.button_TotalSize.Text = "Total Size";
            this.button_TotalSize.UseVisualStyleBackColor = true;
            this.button_TotalSize.Click += new System.EventHandler(this.button_TotalSize_Click);
            // 
            // HeapLeakParser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button_TotalSize);
            this.Controls.Add(this.button_Count);
            this.Controls.Add(this.button_Size);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_TotalSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CallStack);
            this.Controls.Add(this.listBox_Leaks);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_WindbgLogPath);
            this.Controls.Add(this.button_ParseHeapLeak);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "HeapLeakParser";
            this.Text = "HeapLeakParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ParseHeapLeak;
        private System.Windows.Forms.TextBox textBox_WindbgLogPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.ListBox listBox_Leaks;
        private System.Windows.Forms.TextBox textBox_CallStack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TotalSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Size;
        private System.Windows.Forms.Button button_Count;
        private System.Windows.Forms.Button button_TotalSize;
    }
}

