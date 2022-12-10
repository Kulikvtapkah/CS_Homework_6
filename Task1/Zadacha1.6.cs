// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int EnterSmth(string request)
{
    System.Console.Write($"{request}");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

int EnterM()
{
    System.Console.WriteLine("Нужно М чисел... Хмм, как думаете, это сколько?");
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        response = EnterSmth("Введите М >> ");
        if (response > 0)
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Пожалуйста, хотя бы одно число! Начнем с начала:"); }
    }
    return (response);
}

int PositiveSum(int M)
{
    int PosSum = 0;
    System.Console.WriteLine($"Отличный выбор! пусть их будет {M}.");
    System.Console.WriteLine("Теперь введите числа: ");


    for (int i = 0; i < M; i++)
    {
        int Number = EnterSmth(" ");
        if (Number > 0) PosSum++;
    }

    return (PosSum);
}

System.Console.WriteLine("О, Властелин клавиатуры, приветствую вас! ");

System.Console.WriteLine($"Из введенных чисел {PositiveSum(EnterM())} больше нуля!");



