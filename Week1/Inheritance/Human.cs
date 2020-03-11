using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceMammalCatHuman
{
    //abstract is static for classes
    //static cant be inherited
    //abstract can be inherited
    class Human : Mammal
    {
        /*Add a characteristic specific to humans*/
        public string _color;

        //default constructor
        public Human()
        {

        }

        //override constructor
        public Human(bool hasFur, int numLegs, int avgHeartRate, string breathsWith)
        {
            this.hasFur = hasFur;
            this.numLegs = numLegs;
            this.avgHeartRate = avgHeartRate;
            this.breathsWith = breathsWith;
        }

        public override String Says()
        {
            /*what does the amimal say?*/
            return "How YOU Doin?";
        }

        /*Add a action specific to humans*/
        public string FavoriteColor()
        {
            return $"Favorite Color is: {_color}";
        }

        public void Work()
        {

        }
    }
}
