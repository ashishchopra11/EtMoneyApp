using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EtMoneyApp
{
    public partial class MainPage : ContentPage
    {
        public IList<ListView> ListViews { get; private set; }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           ListView selectedItem = e.SelectedItem as ListView;
        }
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView tappedItem = e.Item as ListView;
        }

        public MainPage()
        {
            InitializeComponent();
            ListViews = new List<ListView>();
            ListViews.Add(new ListView
            {
                ImageUrl = "mutual.jpg",
                Name = "SmartDeposit",
                Description = "Earn upto 50% more"

            });
            ListViews.Add(new ListView
            {
                ImageUrl = "mutual.jpg",
                Name = "Spends",
                Description = "0 spends in December"

            });
            ListViews.Add(new ListView
            {
                ImageUrl = "mutual.jpg",
                Name = "Direct Mutual Funds",
                Description = "SIP and one time requirements"

            });
            ListViews.Add(new ListView
            {
                ImageUrl = "mutual.jpg",
                Name = "Loans",
                Description = "Earn upto 50% more quick and fast"

            });
            ListViews.Add(new ListView
            {
                ImageUrl = "mutual.jpg",
                Name = "Insurance",
                Description = "KEy to security for car,bike!!"

            });
            BindingContext = this;
        }
    }
}
