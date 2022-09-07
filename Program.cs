// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

        Console.WriteLine("Введите Трехзначное число");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1000) 
        {
         
         string numberText = Convert.ToString(number);

            if (numberText.Length > 2)
         
               {

                Console.WriteLine("второе число - >" + numberText[1]);

               }

            else 
              
              {

               Console.WriteLine("второго числа нет");


              }


        }

         else 
              
              {

               Console.WriteLine("Число не является трехзначным");


              }