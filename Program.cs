using Mechanic;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a new Car instance with Make, Model, and Year properties
        Car car = new Car("Kia", "Rio", 2011);

        // Add Engine and Tire parts to the Car instance
        car.Parts.Add(new Engine());
        car.Parts.Add(new Tire());

        // Call the overriden ListParts method to list the Car's parts
        car.ListParts();

        // Call the Repair method to repair the Car
        car.Repair();

        // Call the Replace method to replace the Car's parts
        car.Replace();

        Console.ReadLine();
    }
}