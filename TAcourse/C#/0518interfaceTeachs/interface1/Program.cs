using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //執行個體/物件 們
            var 飛馬01 = new 飛馬("飛馬01");
            var 飛魚01 = new 飛魚("飛魚01");
            var 水獺01 = new 水獺("水獺01");
            var 水鳥01 = new 水鳥("水鳥01");

            var 飛機01 = new 飛機();
            var 機器人01= new  機器人();

            //四種集合，空的
            List<Animal> animalList=new List<Animal>();
            List<IFlyable> flyableList=new List<IFlyable>();
            List<IWaikable> waikableList=new List<IWaikable>();
            List<ISwinable> swinableList=new List<ISwinable>();

            //收集然後統一印出
            Console.WriteLine("...動物...");
            animalList.Add(飛馬01);
            animalList.Add(飛魚01);
            animalList.Add(水獺01);
            animalList.Add(水鳥01);
            foreach (Animal 此動物 in animalList)
            {
                此動物.呼吸();
                //此動物.飛();
                //此動物.走();
                //此動物.游();
            }

            Console.WriteLine("...會飛的...");
            flyableList.Add(飛馬01);
            flyableList.Add(飛魚01);            
            flyableList.Add(水鳥01);
            flyableList.Add(飛機01);
            foreach(IFlyable 會飛者 in flyableList)
            {
                會飛者.呼吸();
                會飛者.飛();
                會飛者.走();
                會飛者.游();

            }

            Console.WriteLine("...會走的...");
            waikableList.Add(飛馬01);
            swinableList.Add(水獺01);
            swinableList.Add(水鳥01);
            swinableList.Add(機器人01);

            waikableList.Add(水鳥01);
            foreach (IWaikable 會走者 in waikableList)
            {
                會走者.呼吸();
                會走者.飛();
                會走者.走();
                會走者.游();

            }


            Console.WriteLine("...會游的...");
            swinableList.Add(飛馬01);
            swinableList.Add(飛魚01);
            swinableList.Add(水鳥01);
            swinableList.Add(水獺01);

            foreach (ISwinable 會游者 in swinableList)
            {
                會游者.呼吸();
                會游者.飛();
                會游者.走();
                會游者.游();

            }






        }
    }
}
