using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetUtilX2.Misc;
using Xamarin.Forms;

namespace VetUtilX2
{
    public partial class Dosagem : ContentPage
    {
        string _peso;
        public string Peso
        {
            get
            {
                return _peso;
            }
            set
            {
                if (_peso != value)
                {
                    _peso = value;
                    OnPropertyChanged(nameof(Peso));
                }
            }
        }
        string _dose;
        public string Dose
        {
            get
            {
                return _dose;
            }
            set
            {
                if (_dose != value)
                {
                    _dose = value;
                    OnPropertyChanged(nameof(Dose));
                }
            }
        }

        string _doseApresentacao;
        public string DoseApresentacao
        {
            get
            {
                return _doseApresentacao;
            }
            set
            {
                if (_doseApresentacao != value)
                {
                    _doseApresentacao = value;
                    OnPropertyChanged(nameof(DoseApresentacao));
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
        string _resultadoApresentacao;
        public string ResultadoApresentacao
        {
            get
            {
                return _resultadoApresentacao;
            }
            set
            {
                if (_resultadoApresentacao != value)
                {
                    _resultadoApresentacao = value;
                    OnPropertyChanged(nameof(ResultadoApresentacao));
                }
            }
        }


        ObservableCollection<KeyValuePair<int, string>> _listaUnidades;
        public ObservableCollection<KeyValuePair<int, string>> ListaUnidades
        {
            get
            {
                return _listaUnidades;
            }
            set
            {
                if (_listaUnidades != value)
                {
                    _listaUnidades = value;
                    OnPropertyChanged(nameof(ListaUnidades));
                }
            }
        }

        public Dosagem()
        {

            InitializeComponent();
            CarregarListas();
            
            this.BindingContext = this;

        }
        private void CarregarListas()
        {
            var listaUnidades = new Dictionary<int, string>();
            listaUnidades.Add(0, "mg/Kg");
            listaUnidades.Add(1, "mg/M2 - Canino");
            listaUnidades.Add(2, "mg/M2 - Felino");
            this.ListaUnidades = new ObservableCollection<KeyValuePair<int, string>>(listaUnidades.ToList());
            foreach (var item in listaUnidades)
            {
                pkUnidadesDose.Items.Add(item.Value);
            }
            pkUnidadesDose.SelectedIndex = 0;

            var listaUnidadesApresentacao = new Dictionary<int, string>();
            listaUnidadesApresentacao.Add(0, "mg/comprimido");
            listaUnidadesApresentacao.Add(1, "mg/ml");
            listaUnidadesApresentacao.Add(2, "%");

            foreach (var item in listaUnidadesApresentacao)
            {
                pkUnidadesDoseApresentacao.Items.Add(item.Value);
            }
            pkUnidadesDoseApresentacao.SelectedIndex = 0;

            pkUnidadesDose.SelectedIndexChanged += mudouUnidade;
            pkUnidadesDoseApresentacao.SelectedIndexChanged += mudouUnidade;
            btnCalcular.Clicked += btnCalcular_Click;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void mudouUnidade(object sender, EventArgs e)
        {
            Calcular();

        }
        private void Calcular()
        {
            slResultado.IsVisible = false;
            decimal pesoNum=0;
            decimal doseNum = 0;
            decimal doseApresentacaoNum = 0;
            this.Resultado = string.Empty;
            if (!decimal.TryParse(_peso, out pesoNum) || !decimal.TryParse(_dose, out doseNum))
            {
                return;
            }

            decimal doseTotal = 0;

            switch (pkUnidadesDose.SelectedIndex)
            {
                case 0:
                    {
                        doseTotal = pesoNum * doseNum;
                    }
                    break;
                case 1:
                    {

                    }
                    break;
                case 2:
                    {

                    }
                    break;
                default:
                    
                    break;
            }

            this.Resultado = string.Format("{0:F2} mg", doseTotal);
            slResultado.IsVisible = true;
            this.ResultadoApresentacao = string.Empty;
            if (!decimal.TryParse(_doseApresentacao, out doseApresentacaoNum))
            {
                return;
            }
            decimal resultadoApr = 0;
            string unidade = string.Empty;
            switch (pkUnidadesDoseApresentacao.SelectedIndex)
            {
                case 0:
                    {
                        resultadoApr = doseTotal/doseApresentacaoNum;
                        unidade = "comprimido(s)";
                    }
                    break;
                case 1:
                    {
                        resultadoApr = doseTotal / doseApresentacaoNum;
                        unidade = "mL(s)";
                    }
                    break;
                case 2:
                    {
                        resultadoApr = doseTotal / (doseApresentacaoNum*10);
                        unidade = "mL(s)";
                    }
                    break;
                default:

                    break;
            }

            this.ResultadoApresentacao = string.Format("{0:F2} {1}", resultadoApr, unidade);
        }

    }
}
