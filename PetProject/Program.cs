bool a = true;

Console.WriteLine("Вы в главном меню, введите цифру");

while (a)
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
            a = false;
        }
        else
        {
            Console.WriteLine("Вы ввели неправильное число");
        }
    }
    else
    {
        a = false;

    }
}