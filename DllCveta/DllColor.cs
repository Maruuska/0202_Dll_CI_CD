using System.Drawing;
using Aspose.Svg;
using Aspose.Svg.Drawing;

namespace DllColor
{
    //Методы преобразования между различными цветовыми моделями (RGB, HEX, HSL) 
    public class ConverterColor
    {
        //метод преобразования цвета RGB в HEX
        //принимает структуру Color RGB
        //возвращает строку HEX цвета
        public static string FromRGBtoHEX(System.Drawing.Color color)
        {
            if (color == null || color.IsEmpty)  //обработка пустой структуры color
            {
                return "the color parameter is null";
            }
            try
            {
                return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");  //преобразование цвета rgb в hex
            }
            catch(Exception ex)
            {
                return "Error when converting RGB to HEX";
            }
            
        }

        //метод преобразования цвета HEX в RGB
        //принимает строку HEX цвета 
        //возвращает строку RGB цвета
        public static string FromHEXtoRGB(string colorHEX)
        {
            if(string.IsNullOrEmpty(colorHEX))   //обработка пустой строки colorHEX
            {
                return "the input string is empty or null";
            }
            try
            {
                // добавление "#" если ее нет
                string hex = colorHEX.StartsWith("#") ? colorHEX : "#" + colorHEX;
                Aspose.Svg.Drawing.Color color = Aspose.Svg.Drawing.Color.FromString(hex);  // преобразование строки hex в структуру Color
                return color.ToRgbString();  // преобразование Color в строку rgb
            }
            catch (Exception ex)
            {
                return "Error when converting HEX to RGB";
            }
        }

        //метод преобразования цвета HEX в HSL
        //принимает строку hex
        //возвращает строку hsl
        public static string FromHEXtoHSL(string colorHEX)
        {
            if (string.IsNullOrEmpty(colorHEX))   //обработка пустой строки colorHEX
            {
                return "the input string is empty or null";
            }
            try
            {
                // добавление "#" если ее нет
                string hex = colorHEX.StartsWith("#") ? colorHEX : "#" + colorHEX;
                Aspose.Svg.Drawing.Color color = Aspose.Svg.Drawing.Color.FromString(hex);   // преобразование строки hex в структуру Color
                return color.Convert(ColorModel.Hsl).ToString(false, false, 0);  // Преобразование HEX в HSL 
            }
            catch (Exception ex) 
            {
                return "Error when converting HEX to HSL";
            }
        }

        //метод преобразования цвета RGB в HSL
        //принимает структуру Color RGB
        //возвращает строку hsl
        public static string FromRGBtoHSL(Aspose.Svg.Drawing.Color color)
        {
            if (color == null)  //обработка пустой структуры color
            {
                return "the color parameter is null";
            }
            try
            {
                return color.Convert(ColorModel.Hsl).ToString(false, false, 0);  // Преобразование RGB в HSL 
            }
            catch (Exception ex) 
            {
                return "Error when converting RGB to HSL";
            }
        }
    }
}
//внесение изменений
