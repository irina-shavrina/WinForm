using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.FormClass
{
    static class FormsStorage
    {
        public static Form1 Form1 { get; set; }
        public static Form2 Form2 { get; set; }
        static FormsStorage()
        {
            Form2 = new Form2();
        }
    }
}
