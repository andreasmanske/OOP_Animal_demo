using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_demo.Classes
{
    class Bear : Animal
    {
        public enum color
        {
            white, brown, black
        }
        private color _colorofbear; // some additional properties that are not part of the base class
        public Bear(ref string NameOfBear, color ColorOfBear) : base(ref NameOfBear )
        {
            base.locomotionMethod = LocomotionMethods.on_four_legs;
            _colorofbear = ColorOfBear; // save for it later 
            base.CanEatYou = true;
        }
        // notice the override clause on the virtual method from the animal base class
        public override bool WillEatYou(bool FeelsThreatened, bool isHungry)
        {
            // here we are overriding the animal logic only in the case of a polar bear
            if (_colorofbear == color.white) return true;
            return base.WillEatYou(FeelsThreatened, isHungry);
        }
    }
}
