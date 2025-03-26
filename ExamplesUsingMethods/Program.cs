using DllColor;


var colorRgb = System.Drawing.Color.FromArgb(255, 181, 178); //создание структуры цвета rgb
string colorHex = ConverterColor.FromRGBtoHEX(colorRgb); //преобразования цвета rgb в hex
//Console.WriteLine("rgb(255, 181, 178) -> " + "hex " + colorHex); //вывод результата преобразования на консоль


//создание структуры цвета rgb
var colorRgb2 = Aspose.Svg.Drawing.Color.FromRgb(222, 180, 135);
//преобразования цвета rgb в hsl
string colorHsl = ConverterColor.FromRGBtoHSL(colorRgb2);
//вывод результата преобразования на консоль
Console.WriteLine("rgb(222, 180, 135) -> " + colorHsl); 

//4//3

// 3 
//4 