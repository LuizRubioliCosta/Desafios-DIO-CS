using System;

    class MinhaClasse
    {
        static void Main(string[] args)
        {
            
            var timeInSeconds = int.Parse(Console.ReadLine());

       
            var hours=0;
            var minutes=0;
            var seconds=0;
            hours = timeInSeconds/3600;
            minutes = (timeInSeconds % 3600) / 60;
            seconds =(timeInSeconds % 3600) % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }