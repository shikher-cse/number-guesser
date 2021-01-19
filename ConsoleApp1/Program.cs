using System;
// namespace 
namespace ConsoleApp1
{
    class Program
    {
         static void Main(string[] args)
        {
            appinfo();

            greetings();
            while(true)
            {
                Random random = new Random();
                int correctnumber = random.Next(1, 10);
                //int correctnumber = 7;
                int guess = 0;
                Console.WriteLine(" please guess any number between 1  to 10   and enter : ");
                
                while (guess  != correctnumber)
                {                   
                    string  input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        printcolor(ConsoleColor.Red ,  " please enter an actual number ");
                        continue;
                    }
                    guess = Int32.Parse(input);
                    if( guess  !=  correctnumber)
                    {
                       
                        printcolor(ConsoleColor.Red, " this is wrong number  try again  ");
                    }
                }

                Console.WriteLine(" you are correct");
                Console.WriteLine("DO you want to play number guesser again{Y or N }?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;

                }
                else
                {
                    return;
                }

            }
           
        }
       
        static void appinfo()
        {
            Console.WriteLine("_________Welcome to the gamehub__________");
            string appname = " number guesser ";
            string appversion = "1.0.1";
            string author = " shikher  raina  ";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" this {0} with the version {1}  is created and published by {2}", appname, appversion, author);
            Console.ResetColor();
        }
        static void  greetings()
        {
            Console.WriteLine("HEllo what is your name  ? ");
            string inputname = Console.ReadLine();
            Console.WriteLine("Hello  {0} , lets play  number guesser ! ", inputname);

        }
        static void printcolor(ConsoleColor color ,  string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message );
            Console.ResetColor();
        }


    }
}

