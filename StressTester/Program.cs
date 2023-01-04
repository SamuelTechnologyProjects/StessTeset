using System.IO;

// Resolve name conflicts by explicitly stating the class to use:
public class Program
{
    public static int Current;

    public static int StressAmount;
    public static int Max;
    public int Maxnum;
    public int Currentnum;
    
    private static void Main()
    {
        Console.WriteLine("Low Test 10");
        Console.WriteLine("Meduim Test 100");
        Console.WriteLine("High Test 1000");
        Console.WriteLine("Ultra Test 100000");
        Console.Write("Cpu StressAmount:");
        StressAmount = int.Parse(Console.ReadLine());
        if (StressAmount < 5 && StressAmount > 0)
        {
            Max = 1000;
        }
        if (StressAmount == 5)
        {
            Max = 100000;
        }
        if (StressAmount > 5 && StressAmount < 11)
        {
            Max = 10000000;
        }
        if (StressAmount > 5 && StressAmount > 11)
        {
            Max = 10000000 * StressAmount - 10;
        }
        File.Delete("MyNumbers.log");
        
        while (Current < Max)
        {


            Console.Clear();
            Random r = new Random();
            //Addition
            int xa = r.Next(1, 100000);
            int ya = r.Next(1, 100000);

            int ra = xa + ya;
            File.AppendAllText("MyNumbers.log", ra.ToString());

            //Subtraction
            int xs = r.Next(1, 1000000);
            int ys = r.Next(1, 1000000);
            int rb = xs - ys;
            File.AppendAllText("MyNumbers.log", rb.ToString());
            //Multipltion
            int xm = r.Next(1, 1000000);
            int ym = r.Next(1, 1000000);
            int rc = xm * ym;
            File.AppendAllText("MyNumbers.log", rc.ToString());
            //Divtion
            int xd = r.Next(1, 1000000);
            int yd = r.Next(1, 1000000);
            int rd = xd / yd;
            File.AppendAllText("MyNumbers.log", rd.ToString());
            int xas = r.Next(1, 100000);
            int yas = r.Next(1, 100000);
            int ras = xa + ya;
            File.AppendAllText("MyNumbers.log", ras.ToString());
            //Subtraction
            int xss = r.Next(1, 1000000);
            int yss = r.Next(1, 1000000);
            int rbs = xs - ys;
            File.AppendAllText("MyNumbers.log", rbs.ToString());
            //Multipltion
            int xms = r.Next(1, 100000);
            int yms = r.Next(1, 100000);
            int rcs = xm * ym;
            File.AppendAllText("MyNumbers.log", rcs.ToString());
            //Divtion
            int xds = r.Next(1, 100000);
            int yds = r.Next(1, 100000);
            int rds = xd / yd;
            File.AppendAllText("MyNumbers.log", rds.ToString());
            Current++;
            Console.WriteLine(Current);
        }
        

    }
   
}

