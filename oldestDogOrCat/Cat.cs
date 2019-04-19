using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldestDogOrCat
{
    class Cat : Animal
    {
        public Cat(FurColor fc, DateTime dob) : base(100,"Cat")
        {
            this.fc = fc;
            this.dob = dob;
            this.energyLevel = maxEl;
        }

        public String Meow()
        {
            return "Cat is meowing";
        }

        public override string MakeNoise()
        {
            return Meow();
        }

        public override String Run()
        {
            string returnStr;
            int energyUse = 30;
            if (changeEnergyLevel(energyUse))
            {
                returnStr = "Cat is running - energy level is now " + energyLevel;
            } else
            {
                returnStr = "Cat does not have enough energy to run";
            }
            return returnStr;
        }

        public override String Walk()
        {
            string returnStr;
            int energyUse = 10;
            if (changeEnergyLevel(energyUse))
            {
                returnStr = "Cat is walking";
            }
            else
            {
                this.energyLevel -= energyUse;
                returnStr = "Cat does not have enough energy to Walk";
            }
            return returnStr;
        }
    }
}
