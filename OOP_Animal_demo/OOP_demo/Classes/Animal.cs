using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_demo.Classes
{
    class Animal : Object // <== inherits from Object
    {
        public LocomotionMethods locomotionMethod;
        // this is called the constructor which gets called when you instantiate the class
        // for example : Animal myAnimal = new Animal("Papa Bear");
        // a constructor must be a method that matches the class name
        public Animal(ref string NameGivenToTheAnimal)
        {
            Name = NameGivenToTheAnimal;
            // because the name is passed by reference instead of by value which is default
            // the filth filter will change the name even on the object that called it
            locomotionMethod = LocomotionMethods.DontKnow;
        } 
        // enums are a nice way to keep values consistant across classes 
        // versus just having strings. For instance if you have a condition
        // that says if (LocomotionMethod=="Swiming") and you like thirty of
        // these in your application and now you realize you have been spelling it 
        // wrong all this time you will have to find all those instances versus an
        // enums where the application would not compile unless you were using
        // one of the options  
        public enum LocomotionMethods
        {
            on_four_legs, on_two_legs, by_Swimming, by_Flying, DontKnow
        }
        public readonly bool Multicellular=true;
        private string _name; // holds the value of the Name property
        // Properties like this one called Name
        // are just variables but you can add
        // some logic into the event when
        // the value is assigned and when the value
        // is requested
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // some filth filters
                // the "value" variable is a built name that .net uses
                // because c# is case sensitive you usually will tranform the string into 
                // upper or lower case in order to make a proper evaluation
                if (value.ToLower().Contains("shit") == true) value = value.ToLower().Replace("shit", "poopie");
                _name = value;
            }
        }
        public bool CanEatYou =false; // assume its a nice animal
        public string InterestingFeature = "I'm an animal";
        // a virtual function mean that other classes that inherit from this 
        // can choose to change the logic within if they choose to
        public virtual bool WillEatYou(bool FeelsThreatened, bool isHungry)
        {
            if (CanEatYou == true && FeelsThreatened == true && isHungry == true) return true;
            return false;
        }
        public string AboutMe
        {
            // read only property
            get
            {
                StringBuilder about = new StringBuilder(); // this class makes it faster to concatenate strings at run time
                about.Append("My name is ");
                about.Append(Name);
                about.Append(". I am a ");
                about.Append(this.GetType().Name);
                about.Append(".");
                if (CanEatYou == true)
                {
                    bool willEatuIfThreatened = WillEatYou(true, false);
                    bool willEatuIfHungry = WillEatYou(false, true);
                    about.Append(" I can eat you");
                    if (willEatuIfThreatened == true && willEatuIfHungry == true)
                    {
                        about.Append(" and I probably will.");
                    }
                    else
                    {
                        about.Append(" but I probably won't.");
                    }
                }
                if (base.CanBeSeen == true)
                {
                    about.Append("I can be seen");
                    if (base.HasMass == true)
                    {
                        about.Append(" and I have mass");
                    }
                    else
                    {
                        about.Append(" but I have no mass"); // unlikely 
                    }
                }
                else
                {
                    about.Append("You can not see me with the naked eye");
                    if (base.HasMass == true)
                    {
                        about.Append(" but I have mass");
                    }
                    else
                    {
                        about.Append(" and have no mass"); // unlikely 
                    }
                }
                about.Append(" You would be interested to know that ");
                about.Append(this.InterestingFeature); // you can also use the keyword this when referring to the current class
                if (this.Multicellular == true) about.Append(". I am a multicellular organism and ");
                about.Append("I get around ");
                about.Append(locomotionMethod.ToString().ToLower().Replace("_"," "));
                return about.ToString();
            }
        }
    }
}
