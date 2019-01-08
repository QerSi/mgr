using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace PracaMgr
{
    public class MecierzBledu
    {
        private double[] miary;
        private List<int> decyzje;
        private double truePositive;
        private double falsePositive;
        private double trueNegative;
        private double falseNegative;

        public MecierzBledu(double[] Miary, List<int> decyzje)
        {
            this.miary = Miary;
            this.decyzje = decyzje;
        }

        public double wyliczAcc()
        {
            double wynik = (this.truePositive + this.trueNegative) / (this.truePositive + this.trueNegative + this.falsePositive + this.falseNegative);
            return Math.Round(wynik, 2, MidpointRounding.AwayFromZero);
        }

        public void wyznaczMacierzBledu(double Lambda)
        {
            zerujMacierzBledu();
            bool flaga = false;
            for (int i = 0; i < this.miary.Length; i++)
            {
                flaga = (this.miary[i] >= Lambda);

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

        private void zerujMacierzBledu()
        {
            this.truePositive = 0;
            this.falsePositive = 0;
            this.trueNegative = 0;
            this.falseNegative = 0;
        }
    }
}
