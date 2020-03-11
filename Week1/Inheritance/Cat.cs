using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceMammalCatHuman
{
    class Cat : Mammal
    {
        /*Add a characteristic specific to cats*/
        public string victim = "vase";
        //default constructor
        public Cat()
        {

        }

        //override constructor
        public Cat(bool hasFur, int numLegs, int avgHeartRate, string breathsWith)
        {
            this.hasFur = hasFur;
            this.numLegs = numLegs;
            this.avgHeartRate = avgHeartRate;
            this.breathsWith = breathsWith;
        }

        public override String Says()
        {
            /*what does the amimal say?*/
            return "meow";
        }

        /*Add an action specific to cats*/
        public string BreakStuff()
        {
            return victim;
        }
        public void Sleep()
        {

        }
    }
}
