using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using lecture_1;

internal class Program
{
    //non derived class different assembly for lecture 1
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Car myCar = new Car();
        Console.WriteLine($"my default  car is: {myCar.carModel}");
        myCar.carModel = "my second model car";
        Console.WriteLine($"my changed modal is: {myCar.carModel}");
        Console.WriteLine($"my car price: {myCar.Price}");
        myCar.Price= 30000; 
        Console.WriteLine($"my changed price is: {myCar.Price}");
        Console.WriteLine($"my car default year is: {myCar.Year}");

        randomNumberTest();

    }

    private static void randomNumberTest()
    {
         Random myRandGen = new Random();
        Dictionary<int, int> dicNumbers = new Dictionary<int, int>();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        for (int i = 0; i < 10000; i++)
        {
           var vrNumber =  myRandGen.Next(0, 101);
            try
            {
                dicNumbers.Add(vrNumber, 1);
            }
            catch(Exception ex)
            {
                dicNumbers[vrNumber]++;
            }
        }
        timer.Stop();
        Console.WriteLine($"elapsed time with try catch error {timer.Elapsed.TotalMilliseconds.ToString("NO")}");
    }
    class Car
    {
        public string carModel = "toyota";
        public int Price { get; set; }
        private int _Year = 1999;

        public int Year
        {
            get {if (_Year < 0)
                    _Year = 2000;
                    return _Year;} //get method

            set {
                _Year = value - 10;
                if ( _Year > 3000)
                _Year = 3000;
                  } //set method
        } 
    }
}
