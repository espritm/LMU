using Xamarin.Forms;
using ESCL.WinPhone;
using Windows.Storage;
using System.IO.IsolatedStorage;

[assembly: Dependency(typeof(BaseUrl_WinPhone))]

namespace ESCL.WinPhone
{
    public class BaseUrl_WinPhone : IBaseUrl
    {
        public string Get()
        {
            //IsolatedStorageFile.GetUserStoreForApplication().
            return "";
        }
    }
}