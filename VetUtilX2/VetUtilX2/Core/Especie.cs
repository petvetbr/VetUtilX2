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
    public sealed class Especies
    {
        public static readonly Especies CANINA = new Especies("CANINA", InnerEnum.CANINA, 0);
        public static readonly Especies FELINA = new Especies("FELINA", InnerEnum.FELINA, 1);
        public static readonly Especies EQUINA = new Especies("EQUINA", InnerEnum.EQUINA, 2);
        public static readonly Especies BOVINA = new Especies("BOVINA", InnerEnum.BOVINA, 3);
        public static readonly Especies OVINA = new Especies("OVINA", InnerEnum.OVINA, 4);
        public static readonly Especies CAPRINA = new Especies("CAPRINA", InnerEnum.CAPRINA, 5);
        public static readonly Especies SUINA = new Especies("SUINA", InnerEnum.SUINA, 6);

        private static readonly IList<Especies> valueList = new List<Especies>();

        static Especies()
        {
            valueList.Add(CANINA);
            valueList.Add(FELINA);
            valueList.Add(EQUINA);
            valueList.Add(BOVINA);
            valueList.Add(OVINA);
            valueList.Add(CAPRINA);
            valueList.Add(SUINA);
        }

        public enum InnerEnum
        {
            CANINA,
            FELINA,
            EQUINA,
            BOVINA,
            OVINA,
            CAPRINA,
            SUINA
        }

        private readonly string nameValue;
        private readonly int ordinalValue;
        private readonly InnerEnum innerEnumValue;
        private static int nextOrdinal = 0;

        private int codigo;

        internal Especies(string name, InnerEnum innerEnum, int cod)
        {
            this.Codigo = cod;

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


        public static IList<Especies> values()
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

        public static Especies valueOf(string name)
        {
            foreach (Especies enumInstance in Especies.values())
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