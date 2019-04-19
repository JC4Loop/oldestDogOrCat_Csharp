using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldestDogOrCat
{
    class Dog : Animal
    {
        public Dog(FurColor fc, DateTime dob) : base (200,"Dog")
        {
            this.fc = fc;
            this.dob = dob;
            this.energyLevel = maxEl;
        }

        public string Bark()
        {
            return "Dog is barking";
        }

        public override string MakeNoise()
        {
            return Bark();
        }

        public override String Run()
        {
            string returnStr;
            int energyUse = 50;
            if (changeEnergyLevel(energyUse))
            {
                returnStr = "Dog is running";
            }
            else
            {
                returnStr = "Dog does not have enough energy to run";
            }
            return returnStr;
        }

        public override String Walk()
        {
             string returnStr;
            int energyUse = 20;
            if (changeEnergyLevel(energyUse))
            {
                returnStr = "Dog is walking";
            }
            else
            {
                returnStr = "Dog does not have enough energy to Walk";
            }
            return returnStr;
        }



    }
}
