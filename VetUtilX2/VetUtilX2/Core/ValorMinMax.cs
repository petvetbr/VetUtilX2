using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetUtilCore
{
    /// <summary>
    /// Created by fe_000 on 22/03/2016.
    /// </summary>
    public class ValorMinMax
    {
        private double min;
        private double max;

        public ValorMinMax(double min_, double max_)
        {
            min = min_;
            max = max_;

        }

        public virtual double Min
        {
            get
            {
                return min;
            }
            set
            {
                this.min = value;
            }
        }


        public virtual double Max
        {
            get
            {
                return max;
            }
            set
            {
                this.max = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", min, max);
        }
    
    }

}
