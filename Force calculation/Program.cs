using System;
//Distance calculation
class PhysicsCalculator
{
    static void Main()
    {
        // Get user input for initial velocity
        Console.Write("Enter initial velocity (in meters per second): ");
        double initialVelocity = Convert.ToDouble(Console.ReadLine());

        // Get user input for time
        Console.Write("Enter time (in seconds): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate distance using the formula: distance = initialVelocity * time
        double distance = CalculateDistance(initialVelocity, time);

        // Display the calculated distance
        Console.WriteLine($"The distance traveled is: {distance} meters");
    }

    // Method to calculate distance
    // Formula: distance = initialVelocity * time
    static double CalculateDistance(double initialVelocity, double time)
    {
        return initialVelocity * time;
    }
}
