using DllColor;
using System.Drawing;

namespace ColorDllTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Color myColor = Color.FromArgb(255, 181, 178);  //"FFB5B2"
            string s = myColor.ToString();

            string act = ConverterColor.FromRGBinHEX(myColor);

            Assert.AreEqual("FFB5B2", act);
        }

        [Test]
        public void Test2()
        {
            string s = "#ff31ca";

            string act = ConverterColor.FromHEXinRGB(s);

            Assert.AreEqual("rgb(255, 49, 202)", act);
        }
        //"#ff31ca"
        //result should be: rgb(255, 49, 202)

        [Test]
        public void Test3() 
        {
            string act = ConverterColor.FromHEXinHSL("#DEB487");
            Assert.AreEqual("hsl(31, 57%, 70%)", act);
        }
        //"#DEB487"
        //Результат должен быть: hsl(31.034, 57%, 70%)
    }
}