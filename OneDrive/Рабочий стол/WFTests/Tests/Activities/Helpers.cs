using System;

namespace WinFormsTests.Activities
{
    public static class Helpers
    {
        public static int ReadInt(int left, int right)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var num))
                {
                    if (num >= left && num <= right)
                        return num;

                    Console.WriteLine("Ошибка, неправильно введенные данные, повторите попытку");
                }
            }
        }
    }
}