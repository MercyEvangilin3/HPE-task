﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loancaluclator
{

    class EducationalLoan:Interest
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public double educationAmount;

       
        public void inputforEducational()
        {
            Console.WriteLine("Enter the Principal Amount:");
            double p = Convert.ToDouble(Console.ReadLine());
            log.Debug("The Principal amount is taken from the user");
            Console.WriteLine("Enter the NUmber of Years:");
            int t = Convert.ToInt32(Console.ReadLine());
            log.Debug("The Tenure is taken from the user");
            Console.WriteLine("Enter the Rate of Interest:");
            double r = Convert.ToDouble(Console.ReadLine());
            log.Debug("The rate of interest is taken from the user");

            educationAmount = CalucateInterestforEducational(p, t, r);
            log.Debug("The details are taken from the user for EducationalLoan");

        }

        
    }
}
