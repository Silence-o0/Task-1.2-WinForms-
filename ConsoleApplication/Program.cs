int number=0;
try
{
    number = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("ERROR");
    Environment.Exit(0);
}
Console.WriteLine($"Ви ввели число {number}");
Console.ReadKey(true);