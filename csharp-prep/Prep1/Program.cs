using System;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {
        
        {
            Account savings = new Account("Kevin Ouma Ogutu", 450);
            savings.DepositMoney(450);
            savings.WithdrawMoney(1200);
            Console.WriteLine($"Balance: {savings.Balance()}");
        }
        
        
        
            
        
        
    }
    
}
       