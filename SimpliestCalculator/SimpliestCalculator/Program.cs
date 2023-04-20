﻿Console.WriteLine("Простейший консольный калькулятор для лабораторной работы №5\n");

char again = 'д';
while (again == 'д')
{
    double a;
    double b;
    double total;
    char oper;

    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
    }

    else if (oper == '/')
    {
        if (b == 0)
        {
            Console.WriteLine("Деление на ноль невозможно!");
        }
        else
        {
            total = a / b;
            Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
        }

        
    }
    else
    {
        Console.WriteLine("Неизвестный оператор.");
    }
    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
    again = Convert.ToChar(Console.ReadLine());
}




