//math >=90 or chemistry >= 90 or biology >= 90

//math && chemistry || math && biology || chemistry && biology

int math, biology, chemistry;

Console.WriteLine("enter your math result");
math = Int32.Parse(Console.WriteLine());

Console.WriteLine("enter your biology result");
biology = Int32.Parse(Console.WriteLine();)

Console.WriteLine("enter your chemistry result:");
chemistry = Int32.Parse(Console.WriteLine());

if((math >= 90 chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}