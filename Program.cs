
Console.WriteLine("Введите нижний предел a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите верхний предел b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите количество разбиений интеграла n:");
double n = double.Parse(Console.ReadLine());
StreamWriter sw = new StreamWriter("C:\\Users\\prdb\\source\\repos\\ConsoleApp12\\file.txt");
if (a >= b)
{
    Console.WriteLine("!a должно быть меньше b!");
}
double h = (b - a) / n;

double sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += (a + (i*h)/2);
}
sum *= h;
Console.WriteLine(sum);

Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
double fun = (2 * Math.Pow(x, 2) + 3 * x) * sum;
Console.WriteLine($"Подыинтегральная функция: {fun} Определённый интеграл: {sum}");
sw.WriteLine($"Подыинтегральная функция: {fun} Определённый интеграл: {sum}");
sw.Close();