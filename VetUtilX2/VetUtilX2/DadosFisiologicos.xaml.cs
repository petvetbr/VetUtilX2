using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetUtilCore;
using Xamarin.Forms;

namespace VetUtilX2
{
    public partial class DadosFisiologicos : ContentPage
    {
        Animal _animal;
        public Animal Animal
        {
            get
            {
                return _animal;
            }
            set
            {
                if (_animal != value)
                {
                    _animal = value;
                    OnPropertyChanged(nameof(Animal));
                }
            }
        }



        public DadosFisiologicos()
        {
            InitializeComponent();
            Util.CarregarEspecies(pkEspecie);
            this.BindingContext = this;
        }
        private void EspecieSelecionada(object sender, EventArgs e)
        {

            var tpEsp = (TipoEpecies)Enum.ToObject(typeof(TipoEpecies), pkEspecie.SelectedIndex);
            this.Animal = Config.Especies[tpEsp];
        }
    }
}
