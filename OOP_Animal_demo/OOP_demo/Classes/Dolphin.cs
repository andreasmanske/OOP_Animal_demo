using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_demo.Classes
{
    class Dolphin : Fish
    {
        public Dolphin(ref string NameOfDolphin) : base(ref NameOfDolphin)
        {
            // we already know its a fish so we dont need the below statement anymore
            // base.locomotionMethod = LocomotionMethods.Swimming;
            // however this fish breathes air
            // += is a short cut to saying thisValue = thisValue + 
            base.InterestingFeature += " but I breathe air";
            base.CanEatYou = false; // i guess they could but 
        }
    }
}
