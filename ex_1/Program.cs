// Задача 19 . Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine ("Введите пятизначное число: ");
{
        Console.WriteLine("Введите число: ");
        int numberA = Convert.ToInt32 (Console.ReadLine ());
        string numberB = Convert.ToString (numberA);
        void CheckingNumber (string number)
        {
         if (numberB[0] == numberB[4] & numberB[1] == numberB[3])
            {
            Console.WriteLine($"Это число {numberB} - палиндром.");
            }
            else Console.WriteLine($"Это число {numberB} - не палиндром.");
        }
            if (numberB!.Length == 5)
            {
            CheckingNumber (numberB);
            }
            else Console.WriteLine($"Введите число заново");         
}