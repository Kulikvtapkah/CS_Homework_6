// Задача 5: * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


int EnterSmth(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

int[,] RandMatrix(int ColumnsNum, int RowsNum, int Rmin, int Rmax)
{
    int[,] RandMatrix = new int[RowsNum, ColumnsNum];
    string Result = ("");
    System.Console.WriteLine();
    System.Console.WriteLine("Случайная матрица: ");

    for (int i = 0; i < RowsNum; i++)
    {
        Result = ("");
        for (int j = 0; j < ColumnsNum; j++)
        {
            Random rnd = new Random();

            RandMatrix[i, j] = rnd.Next(Rmin, Rmax);
            Result = Result + RandMatrix[i, j] + "   ";
        }

        System.Console.WriteLine(Result);
    }
    return (RandMatrix);
}

int EnterSize(string request)
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        response = EnterSmth($"{request} ");

        if (response > 0)
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Нужен хотя бы один элемент! Попробуйте еще раз."); }
    }
    return (response);
}

int[] EnterBorders()
{
    int[] borders = { 0, 0 };
    int min = 0;
    int max = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.WriteLine(" Введите границы диапазона: ");
        min = EnterSmth("нижняя ");
        max = EnterSmth("верхняя ");

        if (max >= min)
        {
            borders[0] = min;
            borders[1] = max;
            rightInput = true;
        }
        else { System.Console.WriteLine("Все с ног на голову! Попробуйте еще раз."); }
    }
    return (borders);
}

int RowMaxSum(int[,] Array)
{
    int RowMax = Array[0, 0];
    int RowMaxSum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        RowMax = Array[i, 0];
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] > RowMax) RowMax = Array[i, j];
        }

        RowMaxSum = RowMaxSum + RowMax;
        //System.Console.WriteLine(RowMax);
        //Это для проверки
    }
    return (RowMaxSum);
}

int ClmMinSum(int[,] Array)
{
    int ClmMin = Array[0, 0];
    int ClmMinSum = 0;
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        ClmMin = Array[0, i];
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            if (Array[j, i] < ClmMin) ClmMin = Array[j, i];
        }

        ClmMinSum = ClmMinSum + ClmMin;
        //System.Console.WriteLine(ClmMin);
        //Это для проверки
    }
    return (ClmMinSum);
}




System.Console.WriteLine("Генерируем случайную матрицу. Поехали!");

int[] Borders = EnterBorders();
int[,] Array = RandMatrix(EnterSize("Введите число столбцов"), EnterSize("Введите число строк"), Borders[0], Borders[1]);

int MaxSum = RowMaxSum(Array);
int MinSum = ClmMinSum(Array);

System.Console.WriteLine($"Сумма максимумов по строкам = {MaxSum}.");
System.Console.WriteLine($"Сумма минимумов по столбцам = {MinSum}.");
System.Console.WriteLine($"Разница между суммами = {MaxSum - MinSum}.");
