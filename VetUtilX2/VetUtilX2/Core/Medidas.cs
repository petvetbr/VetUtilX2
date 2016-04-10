using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetUtilCore
{
    /// <summary>
    /// Created by fe_000 on 28/03/2016.
    /// </summary>
    public sealed class Medidas
    {
        public static readonly Medidas MG_COMP = new Medidas("MG_COMP", InnerEnum.MG_COMP, 0);
        public static readonly Medidas MG_ML = new Medidas("MG_ML", InnerEnum.MG_ML, 1);
        public static readonly Medidas PERCENT = new Medidas("PERCENT", InnerEnum.PERCENT, 2);

        private static readonly IList<Medidas> valueList = new List<Medidas>();

        static Medidas()
        {
            valueList.Add(MG_COMP);
            valueList.Add(MG_ML);
            valueList.Add(PERCENT);
        }

        public enum InnerEnum
        {
            MG_COMP,
            MG_ML,
            PERCENT
        }

        private readonly string nameValue;
        private readonly int ordinalValue;
        private readonly InnerEnum innerEnumValue;
        private static int nextOrdinal = 0;

        private int codigo;

        internal Medidas(string name, InnerEnum innerEnum, int cod)
        {
            Codigo = cod;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }


        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }


        public static IList<Medidas> values()
        {
            return valueList;
        }

        public InnerEnum InnerEnumValue()
        {
            return innerEnumValue;
        }

        public int ordinal()
        {
            return ordinalValue;
        }

        public override string ToString()
        {
            return nameValue;
        }

        public static Medidas valueOf(string name)
        {
            foreach (Medidas enumInstance in Medidas.values())
            {
                if (enumInstance.nameValue == name)
                {
                    return enumInstance;
                }
            }
            throw new System.ArgumentException(name);
        }
    }

}
