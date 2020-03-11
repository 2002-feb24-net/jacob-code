using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceMammalCatHuman
{
    /*add the modifier so that this class won't be instantiated*/ 
    abstract class Mammal
    {
        public bool     hasFur       = true;
        public int      numLegs      { get; set; }
        public int      avgHeartRate { get; set; }
        public String   breathsWith  = "lungs";

        //default constructor
        public Mammal()
        {

        }

        //parameterized override constructor
        public Mammal(bool hasFur, int numLegs, int avgHeartRate, string breathsWith)
        {
            this.hasFur = hasFur;
            this.numLegs = numLegs;
            this.avgHeartRate = avgHeartRate;
            this.breathsWith = breathsWith; 
        }

        public abstract String Says();

        public int GetAvgHeartRate()
        {
            /*how many beats per minute?*/
            return avgHeartRate;
        }




    }
}
