using System;

namespace bookingTest.Logger;

public class LoggerUtils
{
    /**
    logger class to provides logger functions
    */
    public static int stepsCount = 0;
    public static void STEP(string msg){
        stepsCount++;
        Console.WriteLine($"Step.....({stepsCount}) {msg}");

    }

}