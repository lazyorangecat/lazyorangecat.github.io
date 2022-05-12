using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human 
                a = new Human();
                a.Name = "小名";
                a.Age = 12;
                a.Gender = true;
    
            Human 
                b = new Human();
                b.Name = "小美";
                b.Age = 18;
                b.Gender = false;


            Role
                tank = new Role();
                tank.Name = "小明";
                tank.ATK = 3;
                tank.HP = 12;

            Role 
                mage = new Role();
                mage.Name = "小美";
                mage.ATK = 6;
                mage.HP = 7;

            tank.Attack(mage);


            Menu order001 = new Menu();
            order001.Foods = new Food[2] {
                new Food{ Name="羹湯",Price =35,Counter=3},
                new Food{ Name="便當",Price =70,Counter=4},
            };

            int subtotal = order001.Foods[1].CalculatesubTotal();
            

        }
    }

    public class Menu
    {
        public Food[] Foods { get; set; }

            
    }
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Counter { get; set; }
        public int CalculatesubTotal()
        {
            return Price * Counter;
        }
    }




    public class Human
    {
        //類別內 可宣告成員 屬性/方法
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }
    }

    public class Role
    {
        public string Name { get; set; }
        public int ATK { get; set; }
        public int HP { get; set; }

        public void Attack(Role enemy)
        {
            enemy.HP -= ATK;
        }
    }

}
