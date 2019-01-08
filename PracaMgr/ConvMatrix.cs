using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace PracaMgr
{
    public partial class ConvMatrix
    {
        private double truePositive;
        private double falsePositive;
        private double trueNegative;
        private double falseNegative;

        public ConvMatrix(double[] Miary, List<int> decyzje, double lambda)
        {
            this.truePositive = 0;
            this.falsePositive = 0;
            this.trueNegative = 0;
            this.falseNegative = 0;
            bool flaga = false;
            for (int i = 0; i < Miary.Length; i++)
            {
                flaga = (Miary[i] >= lambda);

                if (flaga)
                {
                  if (decyzje[i] == 1)
                        this.truePositive++;
                  else
                        this.falsePositive++;
                }
                else
                {
                    if (decyzje[i] == 0)
                        this.trueNegative++;
                    else
                        this.falseNegative++;
                }
            }
        }

        public double wyliczAcc()
        {
            double wynik = (this.truePositive + this.trueNegative) / (this.truePositive + this.trueNegative + this.falsePositive + this.falseNegative);
            return Math.Round(wynik,2, MidpointRounding.AwayFromZero);
        }
    }
}
