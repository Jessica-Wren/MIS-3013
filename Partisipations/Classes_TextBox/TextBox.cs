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
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            /*BackColor = ConsoleColor.
            ForeColor = ConsoleColor.*/
            Text = string.Empty;
        }

        public void DisplayText() 
        {
            
        }
    }
}
