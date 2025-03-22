using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DllColor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Color myColor = Color.FromArgb(255, 181, 178);



            Console.WriteLine(ConverterColor.FromRGBinHEX(myColor));

            Console.ReadKey();
        }
    }
}
