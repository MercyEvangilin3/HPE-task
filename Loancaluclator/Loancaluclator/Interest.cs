using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loancaluclator
{
    public abstract class Interest:ILoan
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Interest));
        private double _interestRate;

        public double PrincipleAmount;
        public double Tenure;
        
      
        public double TotalAmount;

        public double InterestRate
        {
            get
            {
                return _interestRate;
            }

            set
            {
                _interestRate = value;
            }
        }
        /// <summary>
        /// Method for calculating total amount
        /// </summary>
        public void CalculateRepaymentAmount()
        {
            try
            {
                TotalAmount = ((PrincipleAmount * InterestRate * Tenure) / 100) + PrincipleAmount;
                log.Info("Principal:"+ PrincipleAmount);
                log.Info("Tenure:" + Tenure);
                log.Info("Type of Loan:" + this.GetType());
                log.Info("Total Amount:" + TotalAmount);

            }
           catch(System.Exception ex)
            {
                log.Error(ex);
            }
        }

    } 
}
