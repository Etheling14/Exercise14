Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write("X? ");
double x = Convert.ToDouble(Console.ReadLine());    
Console.WriteLine("N? ");
 double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("the taylor value for x = {0} , N = {1}, is: {2}", x,n,taylor (x, n));
Console.WriteLine("the modified taylor  value for x = {0} , N = {1}, is: {2}", x, n, ModifiedTaylor(x, n));
Console.ReadKey();
double ModifiedTaylor(double x, double n)
{
    double s = 0;
    int sig = 1;
    for (int i = 0; i < n; i++)
    {
        double t = Math.Pow(x, i) / Factorial(i) * sig;
        sig *= -1;
        s += t;
    }
    return s;
}



static double taylor (double x, double n)
{
    double s  = 0;  
    for (int i = 0; i < n; i++)
    {
        double t = Math.Pow(x,i)/ Factorial(i);
        s += t;
    }
    return s;
}

static  double Factorial(int i)
{
    double factorial = i;
    if (factorial > 0)
    {
        for (int x = i - 1; x > 0; x--)
        {
            factorial = factorial * x;
        }
        return factorial;
    }
    else
    {
        for (int x = i + 1; x < 0; x++)
        {
            factorial = factorial * x;
        }
        return factorial;
    }

}