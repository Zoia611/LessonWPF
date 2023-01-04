using Microsoft.Win32;
using System;

namespace Task1
{
    internal class SeveFileDialog
    {
        public static implicit operator SeveFileDialog(SaveFileDialog v)
        {
            throw new NotImplementedException();
        }
    }
}