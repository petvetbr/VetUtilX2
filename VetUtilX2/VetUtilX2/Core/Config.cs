using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetUtilCore
{
    public enum TipoEpecies
    {
        Canina,
        Felina,
        Equina,
        Bovina,
        Ovina,
        Caprina,
        Suina

    }

    public static class Config
    {
        static Dictionary<TipoEpecies, Animal> especies;
        public static Dictionary<TipoEpecies, Animal> Especies
        {
            get
            {
                if (especies == null)
                {
                    especies = CriarEspecies();
                }
                return especies;

            }
        }




        private static Dictionary<TipoEpecies, Animal> CriarEspecies()
        {
            var dic = new Dictionary<TipoEpecies, Animal>();
            var Cao = new Animal()
            {
                Especie = "Canina",
                Fc = new ValorMinMax(70, 160),
                Fr = new ValorMinMax(10, 20),
                Gestacao = new ValorMinMax(59, 65),
                Temp = new ValorMinMax(38, 39.2)
            };
            dic.Add(TipoEpecies.Canina, Cao);
            var Gato = new Animal()
            {
                Especie = "Felina",
                Fc = new ValorMinMax(160, 240),
                Fr = new ValorMinMax(26, 30),
                Gestacao = new ValorMinMax(60, 70),
                Temp = new ValorMinMax(37.8, 39.4)
            };
            dic.Add(TipoEpecies.Felina, Gato);
            var Cavalo = new Animal()
            {
                Especie = "Equina",
                Fc = new ValorMinMax(28, 40),
                Fr = new ValorMinMax(10, 14),
                Gestacao = new ValorMinMax(315, 370),
                Temp = new ValorMinMax(37.2, 38.3)
            };
            dic.Add(TipoEpecies.Equina, Cavalo);
            var Boi = new Animal()
            {
                Especie = "Bovina",
                Fc = new ValorMinMax(48, 84),
                Fr = new ValorMinMax(26, 50),
                Gestacao = new ValorMinMax(280, 290),
                Temp = new ValorMinMax(37.2, 38.3)
            };
            dic.Add(TipoEpecies.Bovina, Boi);

            var Ovelha = new Animal()
            {
                Especie = "Ovina",
                Fc = new ValorMinMax(70, 80),
                Fr = new ValorMinMax(16, 34),
                Gestacao = new ValorMinMax(142, 152),
                Temp = new ValorMinMax(38.3, 39.4)
            };
            dic.Add(TipoEpecies.Ovina, Ovelha);

            var Cabra =
                new Animal()
                {
                    Especie = "Caprina",
                    Fc = new ValorMinMax(70, 80),
                    Fr = new ValorMinMax(10, 16),
                    Gestacao = new ValorMinMax(145, 155),
                    Temp = new ValorMinMax(38.2, 40.7)
                };
            dic.Add(TipoEpecies.Caprina, Cabra);

            var Suina = new Animal()
            {
                Especie = "Suína",
                Fc = new ValorMinMax(70, 120),
                Fr = new ValorMinMax(8, 18),
                Gestacao = new ValorMinMax(112, 115),
                Temp = new ValorMinMax(38.0, 39.5)
            };
            dic.Add(TipoEpecies.Suina, Suina);
            return dic;
        }

    }
}
