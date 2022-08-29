using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loancaluclator
{
    interface ILoan
    {
         double CaluclateInterestforHome(double p,int t,double r);

        double CalucateInterestforPersonal(double p, int t, double r);
        double CalucateInterestforEducational(double p, int t, double r);

    }

    
    abstract class Interest:ILoan
    {
        

        public  double  CaluclateInterestforHome(double p,int t,double r)
        {
            double loanAmount = p;
            double interest = r;
            double numberOfYears = t;
            double rateOfInterest = interest / 1200;
            double numberOfPayments = numberOfYears * 12;
            double paymentAmount = loanAmount * rateOfInterest * numberOfPayments;
            double totalAmount = Convert.ToInt32(paymentAmount + loanAmount);
            Console.WriteLine("Total Amout:"+totalAmount);
            return totalAmount;
            //double Total_Interest = p * r * t / 100;
            //double Total_amount = p + Total_Interest;
            //Console.WriteLine("Total Interest:"+Total_Interest);
            //Console.WriteLine("Total Amount:"+Total_amount);
            Console.ReadLine();
        }

        public double CalucateInterestforPersonal(double p,int t,double r)
        {
            double loanAmount = p;
            double interest = r;
            double numberOfYears = t;
            double rateOfInterest = interest / 1500;
            double numberOfPayments = numberOfYears * 12;
            double paymentAmount = loanAmount * rateOfInterest * numberOfPayments;
            double totalAmount = Convert.ToInt32(paymentAmount + loanAmount);
            return totalAmount;
            Console.WriteLine("Total Amout:" + totalAmount);
            //double Total_Interest = p * r * t / 100;
            //double Total_amount = p + Total_Interest;
            //Console.WriteLine("Total Interest:"+Total_Interest);
            //Console.WriteLine("Total Amount:"+Total_amount);
            Console.ReadLine();
        }
        public double  CalucateInterestforEducational(double p, int t, double r)
        {
            double loanAmount = p;
            double interest = r;
            double numberOfYears = t;
            double rateOfInterest = interest / 1000;
            double numberOfPayments = numberOfYears * 12;
            double paymentAmount = loanAmount * rateOfInterest * numberOfPayments;
            int totalAmount = Convert.ToInt32(paymentAmount + loanAmount);

            Console.WriteLine("Total Amout:" + totalAmount);
            return totalAmount;
            //double Total_Interest = p * r * t / 100;
            //double Total_amount = p + Total_Interest;
            //Console.WriteLine("Total Interest:"+Total_Interest);
            //Console.WriteLine("Total Amount:"+Total_amount);
            Console.ReadLine();
        }
    } 

    
    
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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


                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            HomeLoan hl = new HomeLoan();
                            hl.inputforHome();
                            log.Info($"Total Amount for HomeLoan:{hl.homeamount}");
                            //Console.ReadLine();
                            break;
                        case 2:
                            PersonalLoan pl = new PersonalLoan();
                            pl.inputforPersonal();
                            log.Info($"Total Amount for Personal Loan:{pl.personalAmount }");
                            //Console.ReadLine();
                            break;
                        case 3:
                            EducationalLoan el = new EducationalLoan();
                            log.Info($"Total Amount for Personal Loan:{el.educationAmount }");
                            el.inputforEducational();
                            //Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("OOPS;Invalid Option!");
                            log.Warn("Something went wrong");
                            //Console.ReadLine();
                            break;

                    }
                } while (choice < 4);
                //Console.ReadLine();
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }

            Console.ReadLine();
            
        }
    }
}
