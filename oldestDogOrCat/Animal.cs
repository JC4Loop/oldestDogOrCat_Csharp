using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldestDogOrCat
{
    abstract class Animal
    {
        public enum FurColor {Black, Black_Tortie_and_White, Cream, Grey, Cinnamon, Red};
        protected FurColor fc;
        protected static int legs = 4;
        protected DateTime dob;
        protected readonly int maxEl; // maximum energy
        protected int energyLevel;
        protected readonly string anmlType;

        public Animal(int mel,string t)
        {
            maxEl = mel;
            anmlType = t;
        }

        public FurColor Fc
        {
            get { return fc; }
        }

        public DateTime Dob
        {
            get { return dob; }
        }

        public int EnergyLevel
        {
            get { return energyLevel; }
        }

        public string AnmlType
        {
            get { return anmlType; }
        }

        public abstract String Walk();
        public abstract String Run();
        public abstract String MakeNoise();

        public String Sleep()
        {
            int replenishE = 40;
            string returnStr;
            string type;
            if (this is Dog)
            {
                type = "Dog";
            } else
            {
                type = "Cat";
            }

            if (energyLevel == maxEl)
            {
                return type + " can no longer sleep - energy level is " + energyLevel;
            }
            else if (this.energyLevel + replenishE > maxEl)
            {
                this.energyLevel = maxEl;
                returnStr = type + " slept but woke up early";
            } else
            {
                this.energyLevel += replenishE;
                returnStr = type + " is sleeping - energy level is now " + energyLevel;
            }
            return returnStr;
        }

        public int getAgeByMonths()
        {
            DateTime dateToday = DateTime.Now;
           
            int years = dateToday.Year - dob.Year;
            int months = dateToday.Month - dob.Month;
            if (months < 0)
            {
                months = 12 + months; // minus a minus value will add, so need plus
                years -= 1;
            }
            months += (12 * years); 
            return months;
        }

        protected bool changeEnergyLevel(int energyUse)
        {
            if (energyLevel - energyUse < 0)
            {
                return false;
            }
            else
            {
                this.energyLevel -= energyUse;
                return true;
            }
        }
    }
}
