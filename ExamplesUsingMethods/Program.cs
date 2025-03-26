using DllColor;

var colorRgb = System.Drawing.Color.FromArgb(255, 181, 178); //создание структуры цвета rgb
string colorHex = ConverterColor.FromRGBtoHEX(colorRgb); //преобразования цвета rgb в hex
Console.WriteLine("rgb(255, 181, 178) -> " + "hex " + colorHex); //вывод результата преобразования на консоль
