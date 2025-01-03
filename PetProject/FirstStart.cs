using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    public class FirstStart
    {
        public void MainProgram()
        {
            Console.WriteLine("Главное меню, введите цифру");
            bool Switcher = true;
            while (Switcher)
            {
                Console.WriteLine("1. Настройки");
                Console.WriteLine("2. Информация");
                Console.WriteLine("3. Выход");

                string userInsert = Console.ReadLine();

                if (int.TryParse(userInsert, out int result))
                {
                    
                    if (result == 1)
                    {
                        Console.Beep();
                        Console.WriteLine("В разработке...");
                    }

                    else if (result == 2)
                    {
                        Console.WriteLine("Программа была создана в обучающих целях.");
                    }

                    else if (result == 3)
                    {
                        Console.Beep();
                        Console.Beep();
                        Switcher = false;
                    }

                    else
                    {
                        Console.WriteLine("Вы ввели неправильное число");
                    }
                }

                else
                {
                    Console.WriteLine("Вы не ввели число");
                }
            }

        }
    }
}
