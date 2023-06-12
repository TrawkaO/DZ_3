using System.ComponentModel;
using Microsoft.VisualBasic;

int menu = 1;
do
{
    Console.WriteLine("Выберите ДЗ " +
                      "\n 1. Подсчёт площади прямоугольника " +
                      "\n 2. Подсчёт пощади прямоугольного треугольника " +
                      "\n 3. Написать калькулятор (+ - * / %) " +
                      "\n 4. Программа для проверки совершеннолетия " +
                      "\n 5. Программа для проверки температуры на улице"+
                      "\n 6. Программа подсчёта времени года");
    Console.Write("Ваш выбор: ");
    string golos = Console.ReadLine();
    Console.WriteLine();
    string stroka1, stroka2, result;
    int a = 0, b = 0, s = 0;

    switch (golos)
    {
        case "1":

            Console.Write("Введите первую сторону:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую сторону:");
            b = Convert.ToInt32(Console.ReadLine());
            s = a * b;
            Console.WriteLine("Площадь: " + s);
            Console.WriteLine();
            Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
            Console.Write("Ваш выбор: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            break;

        case "2":
            Console.Write("Введите первый катет:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второй катет:");
            b = Convert.ToInt32(Console.ReadLine());
            s = (a * b)/2;
            Console.WriteLine("Площадь: " + s);
            Console.WriteLine();
            Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
            Console.Write("Ваш выбор: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            break;

        case "3":
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак операции: ");
            stroka1 = Console.ReadLine();
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            switch (stroka1)
            {
                case "+":
                    s = a + b;
                    Console.WriteLine("Результат: " + s);
                    Console.WriteLine();
                    Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                    Console.Write("Ваш выбор: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    break;
                case "-":
                    s = a - b;
                    Console.WriteLine("Результат: " + s);
                    Console.WriteLine();
                    Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                    Console.Write("Ваш выбор: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    break;
                case "*":
                    s = a * b;
                    Console.WriteLine("Результат: " + s);
                    Console.WriteLine();
                    Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                    Console.Write("Ваш выбор: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    break;
                case "/":
                    s = a / b;
                    Console.WriteLine("Результат: " + s);
                    Console.WriteLine();
                    Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                    Console.Write("Ваш выбор: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    break;
                case "%":
                    s = a % b;
                    Console.WriteLine("Результат: " + s);
                    Console.WriteLine();
                    Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                    Console.Write("Ваш выбор: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    break;

            }
            break;
        case "4":
            Console.Write("Введите Возраст:");
            a = Convert.ToInt32(Console.ReadLine());
           if (a >= 18)
            {
                 Console.WriteLine("Годен"); 
             
            }
           else
           {
               Console.WriteLine("Негоден");
            }
            Console.WriteLine();
            Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
            Console.Write("Ваш выбор: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            break;
        case "5":
            Console.Write("Введите температуру:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Очень холодно");

            }
            if (a >=0 && a <10 )
            {
                Console.WriteLine("Холодно");
            }
            if (a>=10 && a<20)
            {
                Console.WriteLine("Нормально");
            }
            if (a >= 20 && a < 30)
            {
                Console.WriteLine("Тепло");
            }
            if (a >= 30)
            {
                Console.WriteLine("Жарко");
            }
            Console.WriteLine();
            Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
            Console.Write("Ваш выбор: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            break;
        case "6":
            Console.Write("Введите номер месяца:");
            a = Convert.ToInt32(Console.ReadLine());
           
            if (a >= 3 && a <= 5)
            {
                Console.WriteLine("Весна");
            }
            if (a >= 6 && a <= 8)
            {
                Console.WriteLine("Лето");
            }
            if (a >= 9 && a <= 11)
            {
                Console.WriteLine("Осень");
            }
            if (a > 0 && a < 3 || a == 12 )
            {
                Console.WriteLine("Зима");
            }
            else
            {
                Console.WriteLine("Нет такого месяца");
            }
            Console.WriteLine();
            Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
            Console.Write("Ваш выбор: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            break;

    }

 

} while (menu == 1);






