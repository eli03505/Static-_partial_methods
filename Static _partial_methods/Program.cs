using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Cat
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; set; }
        public int Price { get; set; }
        public int MealQuntity { get; set; }
        public void Eat()
        {
            Energy += 30;
            Price += 10;
        }
        public void Sleep()
        {
            Energy += 40;
        }
        public void Play()
        {
            if (Energy == 0)
            {
                Sleep();
            }
            else
            {
                Energy += 40;
            }
            if (Energy < 0)
            {
                Energy = 0;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****CAT****\n");
            Console.WriteLine($"Nickname:{Nickname}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Gender:{Gender}");
            Console.WriteLine($"Energy:{Energy}");
            Console.WriteLine($"Price{Price}");
            Console.WriteLine($"Meal Qunality{MealQuntity}");
        }
    }
    class CatHause
    {
        public string Name { get; set; }
        public Cat[] Cats { get; set; }
        public int CatCaunt { get; set; }
        public void AddCat(ref Cat cat)
        {
            Cat[] temp = new Cat[++CatCaunt];
            if (Cats != null)
            {
                Cats.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = cat;
            Cats = temp;
        }
        public void RemoveByNickname(string Name)
        {
            Cat[] newCats = new Cat[--CatCaunt];
            for (int i = 0; i < CatCaunt; i++)
            {
                if (Name != Cats[i].Nickname)
                {
                    newCats[i] = Cats[i];
                }
                else
                {
                    for (int k = i, k2 = i + 1; k < CatCaunt; k++, k2++)
                    {
                        newCats[k] = Cats[k2];
                    }
                }
            }
            Cats = newCats;
        }
        public int CatPrice()
        {
            int sum = 0;
            foreach (var item in Cats)
            {
                sum += item.Price;
            }
            return sum;
        }
        public int CatQuantity()
        {
            int sum1 = 0;
            foreach (var item in Cats)
            {
                sum1 += item.MealQuntity;
            }
            return sum1;
        }
        public void ShowCats()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Cat Hause");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Cat Count:{CatCaunt}");
            Console.WriteLine($"Cats Prices{CatPrice()}");
            Console.WriteLine($"Cat Quantity{CatQuantity()}");
            if (Cats != null)
            {
                foreach (var item in Cats)
                {
                    item.Show();
                }
            }
        }
    }
    class PetShop
    {
        public CatHause[] catHauses { get; set; }
        public int CatHaseCaunt { get; set; }
        public void AddCatHauseCunt(ref CatHause catHause)
        {
            CatHause[] temp = new CatHause[++CatHaseCaunt];
            if (catHauses != null)
            {
                catHauses.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = catHause;
            catHauses = temp;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------PETSHOP-------");
            Console.WriteLine($"Cat Hause count:{CatHaseCaunt}");
            Console.WriteLine($"Petshop Cat:{(CatPrice)}");
            Console.WriteLine($"Petshop Quantitiy:{CatQuantity()}");
            foreach (var item in catHauses)
            {
                item.ShowCats();
            }
        }
        private object CatQuantity()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat()
            {
                Nickname = "Tom",
                Age = 0,
                Gender = "Male",
                Price = 300,
                MealQuntity = 40
            };
            Cat cat2 = new Cat()
            {
                Nickname = "Holly",
                Age = 0,
                Gender = "Female",
                Price = 200,
                MealQuntity = 30
            };
            Cat cat3 = new Cat()
            {
                Nickname = "Simba",
                Age = 0,
                Gender = "Male",
                Price = 150,
                MealQuntity = 30
            };
            CatHause cathause = new CatHause()
            {
                Name = "Tom"
            };
            CatHause catHause1 = new CatHause()
            {
                Name = "Flora"
            };
        }
    }
}
