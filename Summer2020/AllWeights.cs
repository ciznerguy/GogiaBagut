using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2020
{
    public class AllWeights
    {
        Weight[] allWeights= new Weight[10];

        public AllWeights(Weight[] allWeights)
        {
            this.allWeights = allWeights;
        }

        

        public Weight[] GetAllWeight ()
        {
            return this.allWeights;
        }

        public Weight Sum ()
        {

            Weight sumWeight = new Weight();
            for (int i=0;i<this.allWeights.Length;i++)
            {
                sumWeight.Add(this.allWeights[i]);

            }
            return sumWeight;
        }
    }
}
