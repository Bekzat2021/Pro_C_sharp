using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Point
    {
        private double x;
        private double y;

        public double X {
            get {
                return x;
            }
            set {
                x = value;
                OnEventChanged();
            }
        }

        public double Y
        {
            get {
                return y;
            }
            set {
                y = value;
                OnEventChanged();
            }
        }

        public event EventHandler PointChanged;

        public void OnEventChanged()
        {
            if (PointChanged!=null)
            {
                PointChanged(this, EventArgs.Empty);
            }
        }
    }
}
