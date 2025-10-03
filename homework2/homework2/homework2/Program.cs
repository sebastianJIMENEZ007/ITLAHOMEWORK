
bool Close = false;


while (!Close)
{
    int number = 0;
    bool truenumber = false;

    while (!truenumber)
    {
        Console.WriteLine("Enter a number");
        string variable = Console.ReadLine();

        truenumber = int.TryParse(variable, out number);

        if (truenumber)
        {
            truenumber = true;
            Console.WriteLine("You entered a valid number");
        }
        else
        {
            Console.WriteLine("You did not enter a valid number, please try again");
        }

    }


        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }


        Console.WriteLine("Do you want to close the program? (y/n)");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            Close = true;
        }

    }




