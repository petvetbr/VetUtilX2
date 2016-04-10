using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace VetUtilX2
{
    public partial class Menu : ContentPage
    {

        public ListView ListView { get { return listView; } }

        public Menu()
        {
            InitializeComponent();
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Dosagem",
                //IconSource = "contacts.png",
                TargetType = typeof(Dosagem)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Parto",
                //IconSource = "todo.png",
                TargetType = typeof(PartoPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Dados Fisiológicos",
                //IconSource = "reminders.png",
                TargetType = typeof(DadosFisiologicos)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
