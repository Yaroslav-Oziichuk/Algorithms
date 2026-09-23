using System;
using System.Runtime.InteropServices;

public class Task2
{
    private  int _month;

    private decimal _amount;

    public Task2(int month, decimal amount)
    {
        _month = month;
        _amount = amount;
    }

    public static void Task()
    {
        Task2[] transactions = new Task2[]
        {
            new Task2(1, 2000),
            new Task2(5, 1500),
            new Task2(4, 2500),
            new Task2(2, 11000),
            new Task2(9, 15000),
            new Task2(7, 9000),
            new Task2(3, 4000),
            new Task2(10, 18000),
            new Task2(8, 7000),
            new Task2(6, 6000)
        };
        decimal[] array = new decimal[12];

        foreach(Task2 tx in transactions)
        {
            if(tx._month >= 1 && tx._month <= 12)
            {
                array[tx._month - 1] += tx._amount;
            }
        }
        Console.WriteLine("Підсумки за місяць: ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Місяць {i + 1}: {array[i]} грн");
        }
    }
}