using System.Security.Cryptography.X509Certificates;

namespace EraaSoft_T4
{
    internal class Program
    {
        static char Menu()
        {
            Console.WriteLine("    P - Print numbers\r\n    A - Add a number\r\n    M - Display mean of the numbers\r\n    S - Display the smallest number\r\n    L - Display the largest number\r\n    Q - Quit\r\n");
            Console.Write("\n\nEnter Your Choice: ");
            return Convert.ToChar(Console.ReadLine());
        }

        static void Print(List<int> l) { 
            foreach (int i in l) Console.Write(i + "  ");
            Console.WriteLine("\n\n\n\n");
        }
        static void AddNum(List<int> l, int x) { 
            l.Add(x);
        }
        static float Mean(List<int> l)
        {
            float tmp= 0;
            foreach (int i in l) tmp += i;
            return tmp / l.Count;
        }

        static int Smallest(List<int> l) { 
            int tmp = l[0];
            foreach(int i in l) 
                if (i < tmp) tmp = i;
            return tmp;
        }
        static int Largest(List<int> l) { 
            int tmp = l[0];
            foreach(int i in l) 
                if (i > tmp) tmp = i;
            return tmp;
        }

        static bool Find(List<int> l , int x) {
            bool f = false;
               
            foreach (int i in l)
                if (i == x )
                    f = true;
            return f;
        }

        static void Main(string[] args)
        {
                List<int> l = new List<int>();
            char c = 'y';
            while (c != 'q' && c != 'Q')
            {
                c=Menu();
                switch (c)
                {
                    case 'P':
                    case 'p':
                        Print(l);
                        break;

                    case 'A':
                    case 'a':
                        Console.Write("Enter the Num: ");
                        AddNum(l, Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 'M':
                    case 'm':
                        Console.WriteLine("The Mean is: " + Mean(l) + "\n\n\n\n") ;
                        break;

                    case 'S':
                    case 's':
                        Console.WriteLine("Smallest Number is: "+ Smallest(l) + "\n\n\n\n");
                        break;

                    case 'L':
                    case 'l':
                        Console.WriteLine("Largest Number is: " + Largest(l) + "\n\n\n\n");
                        break;

                    case 'F':
                    case 'f':
                        Console.Write("Enter the Num: ");
                        if (Find(l,Convert.ToInt32(Console.ReadLine())))
                            Console.WriteLine("Number exists in the List" + "\n\n\n\n");
                        else
                            Console.WriteLine("Number DOESN'T exists in the List" + "\n\n\n\n");
                        break;

                    case 'C':
                    case 'c':
                        Console.WriteLine("Are you sure you want to clear the list?(y/n):");
                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                            l = new List<int>();
                        break;

                    case 'Q':
                    case 'q':
                        Console.WriteLine("Goodbye :)"); ;
                        break;
                    default:
                        Console.WriteLine("Invalide Choice" + "\n\n\n\n");
                        break;
                }
            }
        }
    }
}
