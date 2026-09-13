namespace calculator;

class Program
{
    public static double ReadNumber(string Message)
    {
        double Number;

        while(true) {
        
            Console.Write(Message);
            if((double.TryParse(Console.ReadLine(), out Number)))
            {
                return Number;
            }

            Console.WriteLine("Invalid, Please enter a number");    
        } 

    }

    public static char ReadOperation()
    {
        string? Operation;


        while (true)
        {
            Console.Write("Please enter an operation(+,-,*,/): ");
            Operation = Console.ReadLine();
            Operation = Operation?[0].ToString();

            switch (Operation?[0])
            {
                case '+':
                case '-':
                case '/':
                case '*':
                    return Operation[0];
                default:
                    Console.WriteLine("Invalid,Please enter an operator");
                    break;
            }


        }

    }

    public static double GetResult(double Number1,double Number2,char Operation)
    {
        double Result = 0;

        switch (Operation)
        {
            case '+':
                Result += (Number1 + Number2);
                break;
            case '-':
                Result += (Number1 - Number2);
                break;
            case '/':
                Result += (Number1 / Number2);
                break;
            case '*':
                Result += (Number1 * Number2);
                break;
            default:
                break;
        }
        return Result;
    }

    public static void Run()
    {
        string? Answer;

        do
        {
            double Number1 = ReadNumber("Please enter first number: ");
            double Number2 = ReadNumber("Please enter second number: ");

            char Operation = ReadOperation();

            double Result = GetResult(Number1, Number2, Operation);
            Console.WriteLine($"Result: {Result}");

            Console.Write("Do you want to do another calculation? (y/n): ");
            Answer = Console.ReadLine();

            Answer = Answer?[0].ToString();

        } while (Answer?[0] == 'y');

    }


    static void Main(string[] args)
    {
        Run();
    }
}