using System;

namespace companyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is to collect Company Information");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter your Company's name : ");
            String companyname = Console.ReadLine();
            Console.WriteLine("Enter your Company's address : ");
            String address = Console.ReadLine();
            Console.WriteLine("Enter the Company's contact number : ");
            double phoneNum = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Company's website : ");
            String website = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Manager's Surname : ");
            String managerSur = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Manager's last name : ");
            String ManagerLas = Convert.ToString(Console.ReadLine());
            String managerName = managerSur +" "+ ManagerLas;


            // Final Output
            Console.WriteLine("The Company's name is {0}", companyname);
            Console.WriteLine("The Company's address is {0}", address);
            Console.WriteLine("The Company's contact number is {0:(0#)### ### ####}", phoneNum);
            Console.WriteLine("The Company's website address is {0}", website);
            Console.WriteLine("Your Manager's name is {0}", managerName);

            Console.ReadKey();
        }
    }
}
