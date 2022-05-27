using MyFirstApp.Droid;
using MyFirstApp.Services;


[assembly: Xamarin.Forms.Dependency(typeof(AndroidDeviceInfoService))]

namespace MyFirstApp.Droid
{
    public class AndroidDeviceInfoService : IDeviceInfo
    {
        public string GetName()
        {
            return Android.OS.Build.Device;
        }
    }
}