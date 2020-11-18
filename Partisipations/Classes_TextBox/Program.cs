using System;

namespace Classes_TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox Textbox1 = new TextBox();
            Textbox1.Padding = 10;
            Textbox1.Text = "Hi, im Textbox1.";

            Console.WriteLine();

            TextBox Textbox2 = new TextBox();
            Textbox2.Padding = 50;
            Textbox2.Text = "Hi, I am Texbox2";

            



            Console.ReadKey();
        }
    }
}
