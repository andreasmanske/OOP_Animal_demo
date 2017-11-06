using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_demo.Classes
{
    class Human : Animal
    {
        public Human(ref string NameOfPerson) : base (ref NameOfPerson)
        {
            base.locomotionMethod = LocomotionMethods.on_two_legs;
            base.CanEatYou = true;
            base.InterestingFeature = "I can build complicated machines or give your an atomic wedgy";
        }
        // here we are overriding the logic from the animal base class completely
        public override bool WillEatYou(bool FeelsThreatened, bool isHungry)
        {
            return false; // lets assume its not a cannibal
        }
    }
}
