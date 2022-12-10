// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int EnterSmth(string request)
{
    System.Console.Write($">> {request} ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

void crossPoint(double k1, double b1, double k2, double b2)
{
    if (k1 != k2)
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 2, MidpointRounding.ToEven);
        double y = Math.Round((b1 - k1 * b2 / k2) / (1 - k1 / k2), 2, MidpointRounding.ToEven);

        System.Console.WriteLine($"Прямые пересекаются в точке N({x} ; {y}).");
    }
    else System.Console.WriteLine("Эти прямые параллельны. Они пересекутся только в неевклидовом пространстве)");
}

System.Console.WriteLine("Генерируем уравнения прямых. Пожалуйста, ведите параметры:");

double k1 = EnterSmth("k1 = ");
double b1 = EnterSmth("b1 = ");
double k2 = EnterSmth("k2 = ");
double b2 = EnterSmth("b2 = ");

crossPoint(k1, b1, k2, b2);
