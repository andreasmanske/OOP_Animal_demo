using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_demo.Classes
{
    class Fish : Animal
    {
        public Fish(ref string NameOfFish) : base (ref NameOfFish)
        {
            // now that we are in lower class we now know how it moves about
            base.locomotionMethod = LocomotionMethods.by_Swimming;
            // we are also be a little mean and override any given name 
            base.Name = "Old Man Jenkins";
            base.InterestingFeature = "I like the water very much";
        }
        
    }
}
