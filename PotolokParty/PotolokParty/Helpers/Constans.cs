using Xamarin.Essentials;

namespace PotolokParty.Helpers
{
    public static class Constants
    {
        // URL of REST service
        // public static string RestUrl = "https://localhost:7224/api/orders{0}";
        // URL of REST service (Android does not use localhost)
        // Use http cleartext for local deployment. Change to https for production
        public static string RestUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5224/api/orders{0}" : "http://localhost:5224/api/orders{0}";
    }
}
