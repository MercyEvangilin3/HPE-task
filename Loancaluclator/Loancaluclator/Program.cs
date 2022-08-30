using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loancaluclator
{
   

    
    
    class Program
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {
                //XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));

                int choice;
                
                do
                {
                   
                    Console.WriteLine("Different type of Loans:");
                    Console.WriteLine("1.HomeLoan:");
                    Console.WriteLine("2.Personal Loan:");
                    Console.WriteLine("3.Educational Loan");
                    Console.WriteLine("4.Exit");

                     choice = Convert.ToInt32(Console.ReadLine());
                    if(choice==4)
                    {
                        break;
                    }
                    Console.WriteLine("Enter the Principal Amount");
                    double principalAmoount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Tenure Amount");
                    double tenure = Convert.ToDouble(Console.ReadLine());
                    
                    switch (choice)
                    {
                        case 1:
                            HomeLoan hl = new HomeLoan(principalAmoount,tenure);
                            hl.CalculateRepaymentAmount();
                            Console.WriteLine(hl.TotalAmount);
                            break;
                        case 2:
                            PersonalLoan pl = new PersonalLoan(principalAmoount,tenure);
                            pl.CalculateRepaymentAmount();
                            Console.WriteLine(pl.TotalAmount);
                            break;
                        case 3:
                            EducationalLoan el = new EducationalLoan(principalAmoount,tenure);
                            el.CalculateRepaymentAmount();
                            Console.WriteLine(el.TotalAmount);
                            break;
                        default:
                            Console.WriteLine("OOPS;Invalid Option!");
                            log.Warn("Something went wrong");
                            //Console.ReadLine();
                            break;

                    }
                    } while (choice < 4);
                
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }

            Console.ReadLine();
            
        }
    }
}
