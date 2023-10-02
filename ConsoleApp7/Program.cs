string txt;
do
{
    Console.WriteLine("Выберите операцию: ");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Квадратный корень");
    Console.WriteLine("6. Степень"); 
    Console.WriteLine("7. Процент");
    Console.WriteLine("8. Факториал");
    Console.WriteLine("9. Выйти из программы");
    txt = Console.ReadLine();

    if (txt == "1")
    {
        Console.WriteLine("Введите первое число: ");
        int первоечисло = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int второечисло = int.Parse(Console.ReadLine());
        int сумма = первоечисло + второечисло;
        Console.WriteLine("Результат сложения: " + сумма);
    }
    else if (txt == "2")
    {
        Console.WriteLine("Введите первое число: ");
        int первоечисло = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int второечисло = int.Parse(Console.ReadLine());
        int вычитание = первоечисло - второечисло;
        Console.WriteLine("Результат вычитания: " + вычитание);
    }
    else if (txt == "3")
    {
        Console.WriteLine("Введите первое число: ");
        int первоечисло = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int второечисло = int.Parse(Console.ReadLine());
        int умножение = первоечисло * второечисло;
        Console.WriteLine("Результат умножения: " + умножение);
    }
    else if (txt == "4")
    {
        Console.WriteLine("Введите первое число: ");
        int первоечисло = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int второечисло = int.Parse(Console.ReadLine());
        if (второечисло != 0)
        {
            int деление = первоечисло / второечисло;
            Console.WriteLine("Результат деления: " + деление);
        }
        else
        {
            Console.WriteLine("Ошибка! Деление на ноль невозможно.");
        }
    }
    else if (txt == "5")
    {
        Console.WriteLine("Введите число: ");
        double число = double.Parse(Console.ReadLine());

        if (число >= 0)
        {
            double squareRoot = Math.Sqrt(число);
            Console.WriteLine("Квадратный корень из числа {0} равен {1}", число, squareRoot);
        }
        else
        {
            Console.WriteLine("Ошибка! Квадратный корень из отрицательного числа невозможен.");
        }
    }
    else if (txt == "6")
    {
        Console.WriteLine("Введите число: ");
        int первоечисло = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        int втроечисло = int.Parse(Console.ReadLine());
        int степень = (int)Math.Pow(первоечисло, втроечисло);
        Console.WriteLine("Результат возведения в степень: " + степень);
    }
    else if (txt == "7")
    {
        Console.WriteLine("Введите число: ");
        double число = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите процент: ");
        double процент = double.Parse(Console.ReadLine());

        double результат = (число * процент) / 100;
        Console.WriteLine("Результат вычисления процента: " + результат);
    }
    else if (txt == "8")
    {

        
        
         Console.WriteLine("Введите число: ");
         int число = int.Parse(Console.ReadLine());

         int factorial = 1;
         for (int i = 1; i <= число; i++)
         {
           factorial *= i;
         }

         Console.WriteLine("Факториал числа {0} равен {1}", число, factorial);




    }

} while (txt != "9");
