using Aspose.Svg.Drawing;
using DllColor;
using System.Drawing;

namespace ColorDllTests
{
    public class Tests
    {

        // Тест для проверки, что корректный цвет rgb правильно переводится в цвет hex
        [Test]
        public void TestRGBtoHEX()
        {
            var colorRgb = System.Drawing.Color.FromArgb(255, 181, 178);   //создание цвета rgb
            string actual = ConverterColor.FromRGBtoHEX(colorRgb);      //фактическая строка из метода библиотеки
            Assert.AreEqual("FFB5B2", actual);   //сравнение ожидаемого и фактического результата преобразования цветов
        }

        // Тест для проверки, что некорректный цвет rgb не переводится в цвет hex
        [Test]
        public void ErrorTestRGBtoHEX()
        {
            var colorRgb = System.Drawing.Color.Empty;   //создание пустого цвета rgb
            string actual = ConverterColor.FromRGBtoHEX(colorRgb);      //фактическая строка из метода библиотеки
            Assert.AreEqual("the color parameter is null", actual);   //сравнение ожидаемого и фактического результата преобразования цветов
        }


        // Тест для проверки, что корректный цвет hex правильно переводится в цвет rgb
        [Test]
        public void TestHEXtoRGB()
        {
            string actual = ConverterColor.FromHEXtoRGB("#ff31ca");   //фактическая строка из метода библиотеки
            Assert.AreEqual("rgb(255, 49, 202)", actual);     //сравнение ожидаемого и фактического результата преобразования цветов
        }

        // Тест для проверки, что некорректный цвет hex не переводится в цвет rgb
        [Test]
        public void ErrorTestHEXtoRGB()
        {
            string actual = ConverterColor.FromHEXtoRGB("");   //фактическая строка из метода библиотеки
            Assert.AreEqual("the input string is empty or null", actual);     //сравнение ожидаемого и фактического результата преобразования цветов
        }


        // Тест для проверки, что корректный цвет hex правильно переводится в цвет hsl
        [Test]
        public void TestHEXtoHSL()
        {
            string actual = ConverterColor.FromHEXtoHSL("#DEB487");  //фактическая строка из метода библиотеки
            Assert.AreEqual("hsl(31, 57%, 70%)", actual);   //сравнение ожидаемого и фактического результата преобразования цветов
        }

        // Тест для проверки, что некорректный цвет hex не переводится в цвет hsl
        [Test]
        public void ErrorTestHEXtoHSL()
        {
            string actual = ConverterColor.FromHEXtoHSL(null);   //фактическая строка из метода библиотеки
            Assert.AreEqual("the input string is empty or null", actual);    //сравнение ожидаемого и фактического результата преобразования цветов
        }


        // Тест для проверки, что корректный цвет rgb правильно переводится в цвет hsl
        [Test]
        public void TestFromRGBtoHSL()
        {
            var colorRgb = Aspose.Svg.Drawing.Color.FromRgb(222, 180, 135);   //создание цвета rgb
            string actual = ConverterColor.FromRGBtoHSL(colorRgb);   //фактическая строка из метода библиотеки
            Assert.AreEqual("hsl(31, 57%, 70%)", actual);  //сравнение ожидаемого и фактического результата преобразования цветов
        }
    }
}
