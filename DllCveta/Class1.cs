using System.Drawing;
using Aspose.Svg;
using Aspose.Svg.Drawing;

namespace DllColor
{
    ///https://docs.aspose.com/svg/ru/net/convert-color-codes/
    //Методы для преобразования между различными цветовыми моделями (RGB, HEX, HSL) 
    public class ConverterColor
    {

        //HEX в RGB
        public static string FromHEXinRGB(string colorHEX)
        {
            // Parse HEX color from a string
            var color = Aspose.Svg.Drawing.Color.FromString(colorHEX);

            // Convert HEX to RGB
            string colorRGB = color.ToRgbString();

            return colorRGB;

            //result should be: rgb(255, 49, 202)
        }

        //RGB в HEX
        public static string FromRGBinHEX(System.Drawing.Color colorRGB)
        {
            string colorHEX = colorRGB.R.ToString("X2") + colorRGB.G.ToString("X2") + colorRGB.B.ToString("X2");
            return colorHEX;
        }

        //HEX в HSL
        public static string FromHEXinHSL(string colorHEX)
        {
            // Анализ HEX-цвета из строки 
            var color = Aspose.Svg.Drawing.Color.FromString("#DEB487");

            // Преобразование HEX в HSL 
            string hslColor = color.Convert(ColorModel.Hsl).ToString(false, false, 0);

            // Вывод результата в консоль 
            Console.WriteLine(hslColor);

            // Результат должен быть: hsl(31.034, 57%, 70%)
            return hslColor;
        }

        //HSL в HEX
        public static string FromHSLinHEX(string colorHSL)
        {
            // Parse HSL color from a string
            var color = Aspose.Svg.Drawing.Color.FromString("hsl(31.034, 57%, 70%)");

            // Convert HSL to HEX
            string hexColor = color.ToRgbHexString();

            // Print the result into console
            Console.WriteLine(hexColor);
            //result should be: #DEB486
            return hexColor;
        }

    }
}
