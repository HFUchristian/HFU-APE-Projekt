using MyFirstApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
           
            var deviceInfo = DependencyService.Get<IDeviceInfo>();
            DeviceInfoLabel.Text = deviceInfo.GetName();
        }
    }
}