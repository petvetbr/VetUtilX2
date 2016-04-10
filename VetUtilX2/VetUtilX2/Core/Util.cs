using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetUtilCore
{
    public static class Util
    {
        public static string NOME = "Nome";
        public static int AddOne(int a)
        {
            return a+1;
        }

        //    Note: body surface area (BSA) in square meters = K × (body wt in grams2/3) × 10-4
        //    K = constant (10.1 for dogs and 10.0 for cats)
        public static double GetBodyAreaM2(Especies species, double pesoKg)
        {
            double area = 0;
            double K = 0;
            //switch (species)
            //{
            //    case CANINA:
            //        K = 10.1;
            //        break;
            //    case FELINA:
            //        K = 10;
            //        break;
            //    case EQUINA:
            //        break;
            //    case BOVINA:
            //        break;
            //    case OVINA:
            //        break;
            //    case CAPRINA:
            //        break;
            //    case SUINA:
            //        break;
            //}
            area = K * Math.Pow((pesoKg * 1000), (0.66666666666667)) * 0.0001;
            return area;
        }

    }
}
