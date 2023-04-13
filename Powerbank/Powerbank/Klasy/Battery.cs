using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerbank.Klasy
{
    public class Battery
    {
        public bool Bat1on { get; private set; }
        public bool Bat2on { get; private set; }

        private class SubBat1
        {
            public double ChargePerc { get; private set; }
            public double MaxmAh { get; private set; }

            public SubBat1() 
            {
                this.ChargePerc = 50;
                this.MaxmAh = 16000;
            }
        }
        private class SubBat2
        {
            public double ChargePerc { get; private set; }
            public double MaxmAh { get; private set; }

            public SubBat2()
            {
                this.ChargePerc = 75;
                this.MaxmAh = 24000;
            }
        }
        private SubBat1 bateria1;
        private SubBat2 bateria2;

        public Battery()
        {
            this.Bat1on = true;
            this.Bat2on = true;
            this.bateria1 = new SubBat1();
            this.bateria2 = new SubBat2();
        }

        public Battery(bool on1, bool on2)
        {
            this.Bat1on = on1;
            this.Bat2on = on2;
            this.bateria1 = new SubBat1();
            this.bateria2 = new SubBat2();
        }

        public string Summary()
        {
            double maxmAh = 0;
            double curmAh1 = (bateria1.MaxmAh * bateria1.ChargePerc) / 100;
            double curmAh2 = (bateria2.MaxmAh * bateria2.ChargePerc) / 100;
            double curmAh = 0;
            string a = "Wyłączoną ";
            string b = "Wyłączoną ";
            if (Bat1on == true)
            {
                curmAh += curmAh1;
                a = "Włączoną ";
                maxmAh += bateria1.MaxmAh;
            }
            if (Bat2on == true)
            {
                curmAh += curmAh2;
                b = "Włączoną ";
                maxmAh += bateria2.MaxmAh;
            }
            double BatPercentage = curmAh / maxmAh * 100;

            return "Powerbank z "+a+"Baterią Nr 1 i "+b+"Baterią Nr 2 ma Maksymalną moc: "+maxmAh.ToString()+" mAh jest naładowany na: "+BatPercentage.ToString()+"%";


        }

    }
}
