using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Classes_TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox Textbox1 = new TextBox();
            Textbox1.Text = "Hi, im Textbox1";
            Textbox1.DisplayText();
            
            

            Console.WriteLine();

            TextBox Textbox2 = new TextBox();
            Textbox2.Padding = 50;
            Textbox2.Text = ("Hi, I am Texbox2");
            Textbox2.Padding = 50;
            Textbox2.DisplayText();

            



            Console.ReadKey();
        }
    }
}
