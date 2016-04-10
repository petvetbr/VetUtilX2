using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetUtilCore
{
    public class Animal
    {
        /// <summary>
        /// Created by fe_000 on 22/03/2016.
        /// </summary>


        private string especie;
        private ValorMinMax gestacao;
        private ValorMinMax fc;
        private ValorMinMax fr;
        private ValorMinMax temp;

        public virtual ValorMinMax Gestacao
        {
            get
            {
                return gestacao;
            }
            set
            {
                this.gestacao = value;
            }
        }


        public virtual ValorMinMax Fc
        {
            get
            {
                return fc;
            }
            set
            {
                this.fc = value;
            }
        }


        public virtual ValorMinMax Fr
        {
            get
            {
                return fr;
            }
            set
            {
                this.fr = value;
            }
        }


        public virtual ValorMinMax Temp
        {
            get
            {
                return temp;
            }
            set
            {
                this.temp = value;
            }
        }


        public virtual string Especie
        {
            get
            {
                return especie;
            }
            set
            {
                this.especie = value;
            }
        }

    }

}
