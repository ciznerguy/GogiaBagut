using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2020
{
    public class Weight
    {
        private int kilo;
        private int gram;


        public Weight()
        {
            this.kilo = 0;
            this.gram = 0;
        }

        public Weight(int kilo, int gram)
        {
            this.kilo = kilo;
            this.gram = gram;

        }


        public Weight(int totalGram)
        {
            this.gram = totalGram % 1000; // 3125  k=3 gr=125
            this.kilo = totalGram / 1000;

        }

        public  void Add (Weight other)
            {
            // 2 300 7 100 =9 400
            // 2 900 4 800  // 6 1700

            this.kilo += other.kilo;
            this.gram += other.gram;
            if (this.gram > 999)
            {
                this.kilo++;
                this.gram = (this.gram % 1000);
            }
            
          
            //int tg = this.gram+other.gram+this.kilo*1000+other.kilo*1000;



        }
        public bool Less (Weight other) 
        {
           return this.kilo*1000+this.gram < other.kilo*1000+other.GetGram();
        }

        public int GetKilo()
        {
            return kilo;
        }

        public void SetKilo(int kilo)
        {
            this.kilo = kilo;
        }

        public int GetGram()
        {
            return gram;
        }

        public void SetGram(int gram)
        {
            this.gram = gram;
        }
        
        
        public override string ToString()
        {
            return $"kilo is {this.kilo} gram is {this.gram}";
        }
    
    }

}
