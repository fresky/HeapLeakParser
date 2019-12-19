using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HeapLeakParser
{
    internal class Leak
    {
        public Leak(string pointer, string size)
        {
            Pointer = pointer;
            Size = convertFromHex(size);
            TotalSize = Size;
            Count = 1;
            CallStack = string.Empty;
        }

        private int convertFromHex(string size)
        {
            return Convert.ToInt32(size, 16);
        }

        public string Pointer { get; private set; }
        public int Size { get; private set; }
        public int Count { get; private set; }
        public string CallStack { get; private set; }
        public int TotalSize { get; private set; }

        public void AddCount()
        {
            Count += 1;
            TotalSize += Size;
        }

        public void AppendCallStack(string line)
        {
            CallStack += Environment.NewLine + line;
        }

        public override string ToString()
        {
            return string.Format("{0,12}    {1,12}    {2,12}    {3,12}", Pointer, Size.ToString("#,###0"),
                Count.ToString("#,###0"), TotalSize.ToString("#,###0"));
        }

        public static int CompareBySize(Leak x, Leak y)
        {
            return y.Size.CompareTo(x.Size);
        }

        public static int CompareByCount(Leak x, Leak y)
        {
            return y.Count.CompareTo(x.Count);
        }

        public static int CompareByTotalSize(Leak x, Leak y)
        {
            return y.TotalSize.CompareTo(x.TotalSize);
        }
    }
}