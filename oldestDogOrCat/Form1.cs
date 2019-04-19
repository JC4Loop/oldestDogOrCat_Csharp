using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oldestDogOrCat
{
    public partial class Form1 : Form
    {
        static List<Animal> animals;
        static Animal myAnimal;
        public Form1()
        {
            InitializeComponent();
            createDogsAndCats();
        }

        private void btnGetPet_Click(object sender, EventArgs e)
        {
            if (rbDog.Checked)
            {
                Dog dog = new Dog(Animal.FurColor.Black,DateTime.Now);
           
                foreach (Animal a in animals)
                {
                    if (a is Dog)
                    {
                        //Dog d = (Dog) a;
                        if (a.Dob < dog.Dob)
                        {
                            dog = (Dog) a;
                        }
                    }
                }
                myAnimal = dog;
                outputText(dog.Fc.ToString() + " " + dog.Dob.ToString("yyyy-MM-dd"));
            } else
            {
                Cat cat = new Cat(Animal.FurColor.Black, DateTime.Now);
                foreach (Animal a in animals)
                {
                    if (a is Cat)
                    {
                        if (a.Dob < cat.Dob)
                        {
                            cat = (Cat) a;
                        }
                    }
                }
                myAnimal = cat;
                outputText(cat.Fc.ToString() + " " + cat.Dob.ToString("yyyy-MM-dd"));
            }
        }

        public void outputText(string s)
        {
            textBox1.Text += s;
            textBox1.AppendText(Environment.NewLine);
            UpdateEnergyLabel();
            if (myAnimal.EnergyLevel == 0)
            {
                textBox1.Text += myAnimal.AnmlType + " suddenly went to sleep due to low energy!";
                textBox1.AppendText(Environment.NewLine);
                outputText(myAnimal.Sleep());
            }
        }
        static void createDogsAndCats()
        {
            Animal.FurColor[] furColors = {
                Animal.FurColor.Black,
                Animal.FurColor.Black_Tortie_and_White,
                Animal.FurColor.Cinnamon,
                Animal.FurColor.Cream,
                Animal.FurColor.Grey,
                Animal.FurColor.Red,
                Animal.FurColor.Black,
                Animal.FurColor.Black_Tortie_and_White,
                Animal.FurColor.Cinnamon,
                Animal.FurColor.Cream,
                Animal.FurColor.Grey
            };

            DateTime[] dateTimes = {
                new DateTime(2013,05,06),
                new DateTime(2014,07,24),
                new DateTime(2015,02,14),
                new DateTime(2011,01,10),
                new DateTime(2017,02,27),
                new DateTime(2016,10,02),
                new DateTime(2015,04,20),
                new DateTime(2014,07,23),
                new DateTime(2016,01,18),
                new DateTime(2013,12,11),
                new DateTime(2015,07,30)
            };
            animals = new List<Animal>();

            for (int i = 0; i < dateTimes.Length; i++)
            {
                if (i % 2 == 0)
                {
                    animals.Add(new Dog(furColors[i], dateTimes[i]));
                } else
                {
                    animals.Add(new Cat(furColors[i], dateTimes[i]));
                }
                animals.Add(new Dog(Animal.FurColor.Red, new DateTime(2012, 04, 04)));
                animals.Add(new Dog(Animal.FurColor.Grey, new DateTime(2012, 05, 01)));
                animals.Add(new Cat(Animal.FurColor.Grey, new DateTime(2011, 02, 20)));
                animals.Add(new Cat(Animal.FurColor.Cinnamon, new DateTime(2011, 02, 27)));
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            outputText(myAnimal.Run());
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            outputText(myAnimal.Walk());
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            outputText(myAnimal.MakeNoise());
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            outputText(myAnimal.Sleep());
        }
        
        public void UpdateEnergyLabel()
        {
            int el = myAnimal.EnergyLevel;
            lblEnergy.Text = el.ToString();
        }
    }
}
