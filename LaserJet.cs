using System;

namespace MyAplication
{
    public class LaserJet : PrinterWindows
    {
        public override void Show(){
            Console.WriteLine("LaserJet display dimension: 12*12");
        } 
        public override void Print(){
            Console.WriteLine("LaserJet printer printing ....");
        }
    }
}