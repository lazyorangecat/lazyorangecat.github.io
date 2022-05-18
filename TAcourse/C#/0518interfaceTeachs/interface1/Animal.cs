using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    internal class Animal
    {
        public string Name { get; set; }
        //寫一個建構式避免初始化

        public Animal(string name)//Animal裡面有一個參數的建構式
        {
            Name = name;
        }
        public void 呼吸()//在Animal定義呼吸的方法
        {
            Console.WriteLine($"{Name}在{nameof(呼吸)}");
        }
    }
    //血統（是什麼，同脈絡）
    //能力（會什麼，跨物種）

    class 飛馬 : Animal, IFlyable, IWaikable, ISwinable
    {
        public 飛馬(string name) : base(name)
        {
        }

        public void 游()
        {
            throw new NotImplementedException();
        }

        public void 走()
        {
            throw new NotImplementedException();
        }

        public void 飛()
        {
            throw new NotImplementedException();
        }
    }
    class 飛魚 : Animal, IFlyable, ISwinable
    {
        public 飛魚(string name) : base(name)
        {
        }

        public void 游()
        {
            throw new NotImplementedException();
        }

        public void 飛()
        {
            throw new NotImplementedException();
        }
    }
    class 水獺 : Animal, IWaikable, ISwinable
    {
        public 水獺(string name) : base(name)
        {
        }

        public void 走()
        {
            throw new NotImplementedException();
        }
        public void 游()
        {
            throw new NotImplementedException();
        }
    }
    class 水鳥 : Animal, IFlyable, IWaikable, ISwinable
    {
        public 水鳥(string name) : base(name)
        {
        }

        public void 游()
        {
            throw new NotImplementedException();
        }

        public void 走()
        {
            throw new NotImplementedException();
        }

        public void 飛()
        {
            throw new NotImplementedException();
        }
    }
    class 飛機 : IFlyable
    {
        public void 飛()
        {
            throw new NotImplementedException();
        }
    }
    class 機器人 : IWaikable
    {
        public void 走()
        {
            throw new NotImplementedException();
        }
    }
}
