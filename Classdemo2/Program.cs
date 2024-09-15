
public class Demo
{
    private int var1 = 0;
    private int var2 = 0;
    private int[] arr = new int[10];
    public static void Main(string[] args)
    {
        Demo obj = new Demo();
        //obj.Take_input();
        //int diff = obj.GetDifference(obj.var1, obj.var2);
        //Console.WriteLine("Difference is: " + diff);
        obj.TakeInput2();
        //obj.ReadFile();
        //obj.WriteFile();
    }

    private void Take_input()
    {
        Console.WriteLine("Enter a number:");
        var1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        var2 = Int32.Parse(Console.ReadLine());
    }

    private int GetDifference(int n1, int n2)
    {
        if (n1 > n2) {
            return n1 - n2;
        }
        return n2 - n1;
    }
    private void TakeInput2()
    {
        Console.WriteLine("Enter number");

        var1 = Int32.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Enter a bigger number");
            var2 = Int32.Parse(Console.ReadLine());
            if (var2 > var1) 
                break;
        }
        PrimeChecker(var1, var2);
    }
    private void ReadFile()
    {
        StreamReader reader = new StreamReader("C:\\Users\\Maxim Oleshko\\source\\repos\\Classdemo2\\Classdemo2\\FileName.txt");

        string line = reader.ReadLine();

        int indx = 0;

        while (line != null)
        {
            Console.WriteLine(line);
            arr[indx] = Int32.Parse(line);

            indx++;

            line = reader.ReadLine();
        }
        for (int i=9; i>=0;i--)
        {
            Console.WriteLine(arr[i]);
        }
    }

    private void WriteFile()
    {
        StreamWriter writer = new StreamWriter("C:\\Users\\Maxim Oleshko\\source\\repos\\Classdemo2\\Classdemo2\\output.txt");
        for(int i=0; i<10; i++)
        {
            writer.WriteLine(arr[i]);
        }
        writer.Flush();
    }


    private void PrimeChecker(int start, int end)
    {
        for (int i=start; i<=end; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }

    }
    public bool IsPrime(int target)
    {
        for(int i=2; i<target; i++)
        {
            if(target % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
