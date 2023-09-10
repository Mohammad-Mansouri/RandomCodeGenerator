// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using RandomCodeGenerator;
using System.Linq.Expressions;
using System.Security.Cryptography;

string response = string.Empty;
string initials = string.Empty;
string code = string.Empty;

generateSelector:
Console.Write("Which code do you want to generate, OTP or Random Order Number? (input 'O' for 'OTP' or 'R' for 'Random Order Number') : ");
response = Console.ReadLine();
if (response.ToLower() != "o" && response.ToLower() != "r")
{
    Console.WriteLine("Wrong Input!!! Please try again...");
    goto generateSelector;
}
else
{
    if(response.ToLower() == "r")
    {
    recheckTheInput:
        Console.Write("Do you want your random Code starts with 'initials'? (input 'Y' for 'Yes' or 'N' for 'NO') : ");
        response = Console.ReadLine();

        if (response.ToLower() != "n" && response.ToLower() != "y")
        {
            Console.WriteLine("Wrong Input!!! Please try again...");
            goto recheckTheInput;
        }
        else
        {
            if (response.ToLower() == "y")
            {
            InputInials:
                Console.Write("Please insert your 'initials' characters? (Not more than 3 char!!!) : ");
                initials = Console.ReadLine();
                if (string.IsNullOrEmpty(initials) || initials.Length > 3)
                {
                    Console.WriteLine("Wrong Input!!! Please try again...");
                    goto InputInials;
                }
            }
        }


        code = CreateOderNumber.Create(initials, 8);

        Console.WriteLine();
        Console.WriteLine("Order Number= " + code);
        Console.WriteLine();
        Console.WriteLine("Length of the code: " + code.Length);
    }
    else
    {
    recheckTheInput:
        Console.Write("How many digit should the code be?  (input number 4, 5 or 6) : ");
        response = Console.ReadLine();
        if (response.ToLower() != "4" && response.ToLower() != "5" && response.ToLower() != "6")
        {
            Console.WriteLine("Wrong Input!!! Please try again...");
            goto recheckTheInput;
        }
        else
        {
            switch(response.ToLower())
            {
                case "4":
                    code = OTPCreator.Create(0000, 9999);
                    Console.WriteLine();
                    Console.WriteLine("OTP number= " + code);
                    Console.WriteLine();
                    Console.WriteLine("Length of the code: " + code.Length);
                    break;
                case "5":
                    code = OTPCreator.Create(00000, 99999);

                    Console.WriteLine();
                    Console.WriteLine("OTP number= " + code);
                    Console.WriteLine();
                    Console.WriteLine("Length of the code: " + code.Length);
                    break;
                case "6":
                    code = OTPCreator.Create(00000, 999999);
                    Console.WriteLine();
                    Console.WriteLine("OTP number= " + code);
                    Console.WriteLine();
                    Console.WriteLine("Length of the code: " + code.Length);
                    break;
            }
        }
    }
}




