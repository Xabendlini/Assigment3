using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
    internal class AlcoholOfChoice
    {
        private string AlcoholType;
        private int NumberOfDrinks;
        private bool IceOrNoIce;

        public AlcoholOfChoice(string alcoholType, int numberOfDrinks, bool iceOrNoIce)
        {
            AlcoholType = alcoholType;
            NumberOfDrinks = numberOfDrinks;
            IceOrNoIce = iceOrNoIce;
        }

        public string GetAlcoholChoice()
        {
            return AlcoholType;
        }
        public int GetNumberOfDrinks()
        { 
            return NumberOfDrinks; 
        }
        public bool GetIceOrNoIce()
        { 
            return IceOrNoIce;
        }

    }
}
