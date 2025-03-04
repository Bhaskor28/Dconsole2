using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS;
namespace Dconsole2;


public class UserList
{


//private  List<BankAccount> AcList= new List<BankAccount>();

Dictionary<int, BankAccount>AcList = new Dictionary<int, BankAccount>();
public void AddUser()
{
    
    Console.WriteLine("Enter Account Number: ");
    int acno=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Account Holder Name: ");
    string acholder = Console.ReadLine();
    Console.WriteLine("Enter Initial Balance: ");
    decimal bal = Convert.ToDecimal(Console.ReadLine());
    


        Console.WriteLine("Select Account type:\n1.Regular\n2.Savings");

        int option=Convert.ToInt32(Console.ReadLine()); 


        if (option==1) {
            AcList.Add(acno,new BankAccount(acno, acholder, bal));
            Console.WriteLine("1 Regular user Account created successfully.");
    
        }
        else if (option == 2)
        {
            Console.WriteLine("Enter interest rate: ");
            decimal ir= Convert.ToDecimal(Console.ReadLine());
            AcList.Add(acno,new SavingAccount(acno, acholder, bal, ir));
            Console.WriteLine("1 Savings user Account created successfully.");

        }
        else
        {
            Console.WriteLine("something went wrong");
        }




}

   




}