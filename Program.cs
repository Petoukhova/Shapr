Console.Clear ();
Console.WriteLine("Enter the number squared");

int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number being checked");

int n = Convert.ToInt32(Console.ReadLine());

if (n*n == q)
    Console.WriteLine("Profit!");
else
    Console.WriteLine("Mistake....");