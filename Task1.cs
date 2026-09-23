using System;

public class Task1
{
    public static void Task()
    {
        List<string> log = new List<string>
        {
            "Запис 1: Система запущена",
            "Запис 2: Користувач увійшов",
            "Запис 3: Помилка з'єднання",
            "Запис 4: Спроба повторного підключення",
            "Запис 5: Успішно підключено"
        };

        Console.WriteLine("Журнал у зворотному порядку:");
        
        for (int i = log.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(log[i]);
        }
    }
}