using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample001
{
    internal class MyCalss
    {
        private EventHandler _xChange;
        public event EventHandler XChange
        {
            add { _xChange+=value;}
            remove { _xChange -= value;}
        }
        private void OnXChange()
        {
            //if(_xChange != null)
            //{
            _xChange?.Invoke(this, EventArgs.Empty);
            //}
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set 
            {
                if(_x != value)
                {
                    _x = value;
                    OnXChange();
                }
            }
        }
    }
}
