using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loancaluclator
{
    class HomeLoan : Interest
    {
        private double principalAmoount;

        public HomeLoan(double principalAmoount, double tenure)
        {
            PrincipleAmount = principalAmoount;
            Tenure = tenure;
            InterestRate = 7.5;
        }
    }
}
