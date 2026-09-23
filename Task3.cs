using System;

public class Task3
{
    public static void Task()
    {
        const int N = 5; 
        string[] eventsBuffer = new string[N];
        int currentIndex = 0; 
        int totalEvents = 0;  

        string[] incomingEvents = new string[]
        {
            "Подія 1",
            "Подія 2",
            "Подія 3",
            "Подія 4",
            "Подія 5",
            "Подія 6",
            "Подія 7",
            "Подія 8"
        };

        foreach (var ev in incomingEvents)
        {
            eventsBuffer[currentIndex] = ev; 
            currentIndex = (currentIndex + 1) % N; 
            totalEvents++;
        }

        Console.WriteLine($"Останні {N} подій (від найстарішої до найновішої):");

        int count = Math.Min(totalEvents, N);
        
        int startIndex = (totalEvents < N) ? 0 : currentIndex;

        for (int i = 0; i < count; i++)
        {
            int index = (startIndex + i) % N;
            Console.WriteLine(eventsBuffer[index]);
        }
    }
}