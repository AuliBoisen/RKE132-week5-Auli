//temp <= 0 - freezing cold/temp > 0 and temp < 10 - cold
//temps >= 10and temp < 15 - chilly
//temp >=15 and temp < 20 - warm 
//temp >= 20 and temp < 30 - hot
//temp >= 30 - boiling hot

Console.WriteLine("enter the temperature: ");
int temp = Int32.Parse(Console.WriteLine());

if(temp >= 30)
{
    Console.WriteLine("Boiling hot.");
}
else if (temp <30 && temp >= 20)
{
    Console.WriteLine("hot.");
}
else if(temp < 20 &&temp >= 15)
{
    Console.WriteLine("warm");
}
else if(temp <15 && temp >= 10)
{
    Console.WriteLine("chilly.");
}
else if (temp < 10 && temp > 0)
{
    Console.WriteLine("cold");
}
else
{
    Console.WriteLine("freezing cold");
}

