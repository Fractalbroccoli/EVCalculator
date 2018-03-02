using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVCalc
{
    public class EVMath
    {




        static public double SimplifyPotOddsRatio(double total, double bet)
        {
            const int percentMultiplier = 100;

            double oddsAsPercent = (bet / total) * percentMultiplier;


            return oddsAsPercent;
        }


        static public double ExpectedValue(double chanceOfA, double chanceOfB, double profitA, double profitB)
        {
            double expectedValue = 0;

            expectedValue = (chanceOfA * profitA) + (chanceOfB * profitB);


            return expectedValue;
        }



    }
}
