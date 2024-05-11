using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
          int choice = 1;    
        while (choice != 0)
 {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Draw the rectangle");
        Console.WriteLine("2. square triangle botton-right");
        Console.WriteLine("3. square triangle botton-left");
        Console.WriteLine("4. square triangle top-left");
        Console.WriteLine("5. square triangle top-right");
        Console.WriteLine("6 Draw isosceles triangle");
        Console.WriteLine("0. Exit");
        Console.WriteLine("Enter your choice:");

        choice = Convert.ToInt32(Console.ReadLine());
                
        switch (choice)
        {
            case 1:
            for (int i=1; i<=3; i++)
            {
                for (int j=1;j<=5;j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            break;    

            case 2:
            for (int i=5; i >= 1; i--)
            {
                for (int j=1; j<=5; j++)  
                {
                    if(j<=(5-i))
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine() ;
            }
            break;
            case 3:
            for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                  if(j<=(6-i))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine() ;
            }  
            break;

            case 4: 
            for (int i=1; i <= 5; i++)
            {
                for (int j=1; j<=i; j++)  
                {
                    if(j<=i)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine() ;
            }
            break;   

            case 5:
            for(int i =5; i >=1;i--)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if (j<i)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine();
            }    
            break;

            case 6:
            for(int i  = 0; i < 7; i++)
            {
                for(int j = 1; j<= 7 - i; j++)
                {
                    Console.Write ("   ");
                }
                for(int j =1; j<=2 * i - 1; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            break;
            case 0:
            Environment.Exit(0);
            break;
            default:
            Console.WriteLine("No Choice");
            break;
        }
 }
    }
}
