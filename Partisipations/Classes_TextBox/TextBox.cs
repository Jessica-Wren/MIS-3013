using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Classes_TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public static ConsoleColor BackColor { get; set; }
        public static ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }



        public TextBox()
        {
            Padding = 0;
            BackColor = ConsoleColor.Blue;
            ForeColor = ConsoleColor.DarkYellow;
            Text = string.Empty;
        }

        public void DisplayText()
        {

            Padding = 0;
            BackColor = ConsoleColor.Blue;
            ForeColor = ConsoleColor.DarkYellow;
            Padding = 0;
            Text = "";
            string output = (Padding + Text + Padding);
            return;

        }
    
    }
}
