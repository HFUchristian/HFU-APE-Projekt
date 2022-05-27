using MyFirstApp.iOS;
using MyFirstApp.Services;

[assembly: Xamarin.Forms.Dependency(typeof(IosDeviceInfoService))]

namespace MyFirstApp.iOS
{
    public class IosDeviceInfoService : IDeviceInfo
    {
        public string GetName()
        {
            return UIKit.UIDevice.CurrentDevice.Name;
        }
    }
}