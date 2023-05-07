//math >= 90; biology >=90, chemistry >= 90;


int math, biology, chemistry;

Console.WriteLine("enter your math result");
math = Int32.Parse(Console.WriteLine());

Console.WriteLine("enter your biology result:");
biology = Int32.Parse(Console.WriteLine());

Console.WriteLine("enter your chemistry result:");
chemistry = Int32.Parse(Console.WriteLine());

if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("congratulations! you got accepted");
}
else
{
    Console.WriteLine("your application cannot be approved.");
}