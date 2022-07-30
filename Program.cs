namespace numbers_functions_csharp
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(10 / 3);//just a  regular divivsion
        Console.WriteLine(Math.Pow(10, 3));//gives 10 raise to 3
        Console.WriteLine(Math.Abs(-100));//gives absolute value
        Console.WriteLine(Math.Sqrt(49));//gives square root
        Console.WriteLine(Math.Max(50, 50.5));//gives the greater and Min does the opposite
        Console.WriteLine(Math.Round(50.9));//rounds the number
        Console.Write("Enter a number: ");

        string txt = Console.ReadLine();
        Console.WriteLine("You entered: " + txt);
        Class1 class1 = new Class1(); // assigning a variable to the class and defining it i think 
        class1.sum_calc(); //calling the function

    }
}
}

