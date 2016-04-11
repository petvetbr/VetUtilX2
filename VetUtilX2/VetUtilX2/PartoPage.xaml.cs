using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetUtilCore;
using Xamarin.Forms;

namespace VetUtilX2
{
    public partial class PartoPage : ContentPage
    {
        DateTime _data;
        public DateTime Data
        {
            get
            {
                return _data;
            }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    OnPropertyChanged(nameof(Data));
                }
            }
        }

        string _resultado;
        public string Resultado
        {
            get
            {
                return _resultado;
            }
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public PartoPage()
        {
            InitializeComponent();
            this.Data = DateTime.Now;
            Util.CarregarEspecies(pkEspecie);
            this.BindingContext = this;
        }
      
        private void DataSelecionada(object sender, EventArgs e)
        {
            Calcular();
        }
        private void EspecieSelecionada(object sender, EventArgs e)
        {
            Calcular();
        }
        private void Calcular()
        {
            
            var tpEsp =(TipoEpecies) Enum.ToObject(typeof(TipoEpecies), pkEspecie.SelectedIndex);
            var especie = Config.Especies[tpEsp];
            DateTime dtMin = _data.AddDays(especie.Gestacao.Min);
            DateTime dtMax = _data.AddDays(especie.Gestacao.Max);
            Resultado = string.Format("{0:d} - {1:d}", dtMin, dtMax);
        }
    }
}
