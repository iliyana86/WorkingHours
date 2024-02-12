int hour = int.Parse(Console.ReadLine());
string week = Console.ReadLine();
//hour = 0;
if ((hour <= 18 && (week == "Monday") && hour >= 10))
{
    Console.WriteLine("open");
}
else if ((hour <= 18 && (week == "Tuesday") && hour >= 10))
{
    Console.WriteLine("open");
}
else if ((hour <= 18 && (week == "Wednesday") && hour >= 10))
{
    Console.WriteLine("open");
}
else if ((hour <= 18 && (week == "Thursday") && hour >= 10))
{
    Console.WriteLine("open");
}
else if ((hour <= 18 && (week == " Friday") && hour >= 10))
{
    Console.WriteLine("open");
}
else if ((hour <= 18 && (week == "Saturday") && hour >= 10))
{
    Console.WriteLine("open");
}
else if ((hour <= 18 && (week == "Sunday") && hour >= 10))
{
    Console.WriteLine("closed");
}
else
{
    Console.WriteLine("closed");
}











