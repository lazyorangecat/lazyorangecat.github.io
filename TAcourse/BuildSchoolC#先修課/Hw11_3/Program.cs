using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw11_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Role
                tank = new Role();
            tank.Name = "小明";
            tank.AttackPower = 3;
            tank.HealthPoint = 12;
            tank.Defence = 3;

            Role
                mage = new Role();
            mage.Name = "小美";
            mage.AttackPower = 6;
            mage.HealthPoint = 7;
            mage.Defence = 1;
            Program.Battle(mage, tank);
            Console.ReadLine();
        }
        static void Battle(Role attacker, Role defender)
        {
            //while (attacker.HealthPoint > 0 && defender.HealthPoint > 0)
            //{

            //    Console.Write($"{ attacker.Name}攻擊{defender.Name}，造成{attacker.Attack(defender)}損傷，");
            //    if (defender.HealthPoint > 0)
            //        Console.WriteLine($"{defender.Name}剩下{defender.HealthPoint}血量");
            //    else
            //    {
            //        Console.WriteLine($"{defender.Name}死亡");
            //        break;
            //    }

            //    Role temp = attacker;
            //    attacker = defender;
            //    defender = temp;
            //}
            while(attacker.HealthPoint>0 )
            {
                attacker.Attack(defender);
                Role temp = attacker;
                attacker = defender;
                defender = temp;

            }
        }
    }
    public class Role
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int HealthPoint { get; set; }

        public int Defence { get; set; }

        public void Attack(Role enemy)
        {
            int damage = AttackPower - enemy.Defence;
            enemy.HealthPoint -= damage;

            Console.Write($"{Name}攻擊{enemy.Name}，造成{damage}損傷，");
            if (enemy.HealthPoint > 0)
                Console.WriteLine($"{enemy.Name}剩下{enemy.HealthPoint}血量");
            else                     
                Console.WriteLine($"{enemy.Name}死亡");

        }
    }
}




