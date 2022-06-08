using System;

namespace MyAplication
{
    public class PrinterWindows
    {
        public virtual void Show(){
            Console.WriteLine("Printer display dimension: ");
        }
        public virtual void Print(){
            Console.WriteLine("Printer Printing .....");
        }
    }
}
