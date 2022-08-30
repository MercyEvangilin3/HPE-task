using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net;

namespace Loancaluclator
{

    class PersonalLoan:Interest
    {
        public PersonalLoan(double principalAmount,double tenure)
        {
            PrincipleAmount = principalAmount;
            Tenure = tenure;
            InterestRate = 12.5;
        }

      
     
    }
}
