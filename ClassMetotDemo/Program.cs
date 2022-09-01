using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;

            CustomerManager customerManager = new CustomerManager();

            while (isContinue)
            {
                int process = Menu();


                switch (process)
                {
                    case 1:
                        Console.WriteLine("Please enter name of customer");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter surname of customer");
                        string surname = Console.ReadLine();
                        customerManager.AddCustomer(name, surname);
                        break;

                    case 2:
                        customerManager.ShowCustomers();
                        break;

                    case 3:
                        Console.WriteLine("Please enter the Id of which customer do you want to delete");
                        int sd = Convert.ToInt32(Console.ReadLine());
                        customerManager.DeleteCustomer(sd);
                        break;
                    case 4:
                        isContinue = false;
                        break;


                }


                static int Menu()
                {
                    Console.WriteLine("Which of them do you want process");
                    Console.WriteLine("1: Add customer");
                    Console.WriteLine("2: List customers");
                    Console.WriteLine("3: Delete customer");
                    Console.WriteLine("4: Exit");
                    int process = Convert.ToInt32(Console.ReadLine());
                    return process;
                }
            }
        }
    }
}
