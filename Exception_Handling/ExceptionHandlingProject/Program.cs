try{
    Console.Write("Enter 1st Number : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd Number : ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum of {a} and {b} is: {a + b}");

double x = (double)a/b;

Console.WriteLine($"Divison of {a} and {b} is {x}");

if(a%b == 0){

    throw new CustomException("Why divide by zero");
}
}

catch(FormatException nfe)
{
    Console.WriteLine($"{nfe.Message} Must be a number");
}
catch(OverflowException ofe)
{
    Console.WriteLine(ofe.Message);
}

catch(DivideByZeroException dbe)
{
    Console.WriteLine(dbe.Message);
}


catch(Exception e)
{
    Console.WriteLine(e.Message);
}

finally{
    Console.WriteLine("Always Execute Finally");
}

Console.WriteLine("The program End");

