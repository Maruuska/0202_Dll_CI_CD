using Aspose.Svg.Drawing;
using DllColor;
using System.Drawing;

namespace ColorDllTests
{
    public class Tests
    {
        // ���� ��� ��������, ��� ���������� ���� rgb ��������� ����������� � ���� hex
        [Test]
        public void TestRGBtoHEX()
        {
            var colorRgb = System.Drawing.Color.FromArgb(255, 181, 178);   //�������� ����� rgb
            string actual = ConverterColor.FromRGBtoHEX(colorRgb);      //����������� ������ �� ������ ����������
            Assert.AreEqual("FFB5B2", actual);   //��������� ���������� � ������������ ���������� �������������� ������
        }

        // ���� ��� ��������, ��� ������������ ���� rgb �� ����������� � ���� hex
        [Test]
        public void ErrorTestRGBtoHEX()
        {
            var colorRgb = System.Drawing.Color.Empty;   //�������� ������� ����� rgb
            string actual = ConverterColor.FromRGBtoHEX(colorRgb);      //����������� ������ �� ������ ����������
            Assert.AreEqual("�������� color ����� null", actual);   //��������� ���������� � ������������ ���������� �������������� ������
        }


        // ���� ��� ��������, ��� ���������� ���� hex ��������� ����������� � ���� rgb
        [Test]
        public void TestHEXtoRGB()
        {
            string actual = ConverterColor.FromHEXtoRGB("#ff31ca");   //����������� ������ �� ������ ����������
            Assert.AreEqual("rgb(255, 49, 202)", actual);     //��������� ���������� � ������������ ���������� �������������� ������
        }

        // ���� ��� ��������, ��� ������������ ���� hex �� ����������� � ���� rgb
        [Test]
        public void ErrorTestHEXtoRGB()
        {
            string actual = ConverterColor.FromHEXtoRGB("");   //����������� ������ �� ������ ����������
            Assert.AreEqual("������� ������ ������ ��� null", actual);     //��������� ���������� � ������������ ���������� �������������� ������
        }


        // ���� ��� ��������, ��� ���������� ���� hex ��������� ����������� � ���� hsl
        [Test]
        public void TestHEXtoHSL()
        {
            string actual = ConverterColor.FromHEXtoHSL("#DEB487");  //����������� ������ �� ������ ����������
            Assert.AreEqual("hsl(31, 57%, 70%)", actual);   //��������� ���������� � ������������ ���������� �������������� ������
        }

        // ���� ��� ��������, ��� ������������ ���� hex �� ����������� � ���� hsl
        [Test]
        public void ErrorTestHEXtoHSL()
        {
            string actual = ConverterColor.FromHEXtoHSL(null);   //����������� ������ �� ������ ����������
            Assert.AreEqual("������� ������ ������ ��� null", actual);    //��������� ���������� � ������������ ���������� �������������� ������
        }


        // ���� ��� ��������, ��� ���������� ���� rgb ��������� ����������� � ���� hsl
        [Test]
        public void TestFromRGBtoHSL()
        {
            var colorRgb = Aspose.Svg.Drawing.Color.FromRgb(222, 180, 135);   //�������� ����� rgb
            string actual = ConverterColor.FromRGBtoHSL(colorRgb);   //����������� ������ �� ������ ����������
            Assert.AreEqual("hsl(31, 57%, 70%)", actual);  //��������� ���������� � ������������ ���������� �������������� ������
        }
    }
}