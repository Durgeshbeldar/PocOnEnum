using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PocOnEnum
{
    // Hello, This Program Implement the POC on Enumuration in C#

    /* ===================================================================================================
       Defination of Enum : Enum is a special data type in programming that defines a set of named values, 
       representing fixed options or constants. 
       The Primery use case of Enum is to make code Readable and Manageble and easy to understand.
       without Enum we will use string or integer values which will make our code less readable and 
       and prone to errors and hard to maintain the code */

    // Following is the Implementation of Enum for different Payment Methods we used on Ecommerce Site.
    
    /* Here in this example I have specify the Enum in Namespace but we can used it in Class and Namespace
       as  well but depending on the project and use case we specify the Enum in class or namespace.
       if we want to access the group of constant data through out the project then it is better to specify enum in
       in the Namespace if the data is needed for class only then we can implement it in class as well. */

    
    // To define the enum we used enum keyword. and define the constant grou of data into it.
    public enum PaymentMethod
    {
        DebitCard = 1,       // Here enum itself provide the integer value for each data and by default start value is 0
        CreditCard,      // 1
        UPI,             // 2
        InternetBanking, // 3
        eWallet,         // 4
        PayPal,          // 5
        CashOnDelivery   // 6
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // **** Following Code Demonstrate How We can used Enum as required. *****

            // Declaration with initialization of Enum Variable 
            //PaymentMethod selectMethod = PaymentMethod.DebitCard; // Lets comment this code make it Dynamic

            Console.WriteLine("Enter the Number to select Payment Method : \n");
            PaymentMethod selectMethod = new PaymentMethod();
            
            for (int i = 1; i <=7; i++) {
                selectMethod = (PaymentMethod)(i);
                Console.WriteLine($"  {i}. {selectMethod}"); // To display the options to user
            } // We can use typeof Operator as well ...
            Console.Write("  : ");

            int selectNo = int.Parse(Console.ReadLine()); // taking input from user
            selectMethod = (PaymentMethod)(selectNo); // Explicit Type Casting..


            Console.WriteLine("\n****** Implementation of Enum in Switch Cases ******\n");
            // To Proceed the Payment we will call ProcessPayment Method
            ProcessPayment(selectMethod);


            Console.WriteLine("\n***** Explicitely TypeCasting Integer to PaymentMethod & Vice-Versa *****\n");

            PaymentMethod PayToInt = (PaymentMethod)(3); // Integer to PaymentMethod Typecasting
            int optionNumber = (int)PayToInt;  // PaymentMethod to Integer Typecasting

            Console.WriteLine($"\nSelected Payment Method For PayToInt is {PayToInt}");
            Console.WriteLine($"Selected PaymentMethod Option in Integer is {optionNumber}\n");
        }

        static void ProcessPayment(PaymentMethod selectedMethod)
        {
            // Here we are switching the switch cases with meaningfull names.
            switch (selectedMethod)
            {
                case PaymentMethod.DebitCard:
                    Console.WriteLine("Payment is Processed Successfully by Debit Card");
                    break;
                case PaymentMethod.CreditCard:
                    Console.WriteLine("Payment is Processed Successfully by Credit Card");
                    break;
                case PaymentMethod.UPI:
                    Console.WriteLine("Payment is Processed Successfully by UPI");
                    break;          
                case PaymentMethod.InternetBanking:
                    Console.WriteLine("Payment is Processed Successfully by Internet Banking");
                    break;
                case PaymentMethod.eWallet:
                    Console.WriteLine("Payment is Processed Successfully by E Wallet"); 
                    break;
                case PaymentMethod.PayPal:
                    Console.WriteLine("Payment is Processed Successfully by PayPal");
                    break;
                case PaymentMethod.CashOnDelivery:
                    Console.WriteLine("Payment will be collected at the Time of Delivery");
                    break;
                default:
                    Console.WriteLine("Invalid Input... Transaction Failed..!");
                    break;
            }
        }
    }
}
// This is how we can use the enum in our projects as per requirement... Thank you...
