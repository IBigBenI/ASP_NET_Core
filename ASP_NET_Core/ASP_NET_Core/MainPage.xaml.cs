using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ASP_NET_Core
{
    public partial class MainPage : ContentPage
    {
        ApplicationViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ApplicationViewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            await viewModel.GetFriends();
            base.OnAppearing();
        }
    }

}
