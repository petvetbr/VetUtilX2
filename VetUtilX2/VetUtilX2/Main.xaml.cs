using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace VetUtilX2
{
    public partial class Main : MasterDetailPage
    {
        Menu masterPage;

        public Main()
        {
            InitializeComponent();
            masterPage = new Menu();
            Master = masterPage;
            Detail = new NavigationPage(new Content());
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                var d = new Dosagem();
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
