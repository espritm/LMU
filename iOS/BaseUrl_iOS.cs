using Xamarin.Forms;
using ESCL.iOS;
using Foundation;

[assembly: Dependency (typeof (BaseUrl_iOS))]

namespace ESCL.iOS 
{
	public class BaseUrl_iOS : IBaseUrl 
	{
		public string Get () 
		{
			return NSBundle.MainBundle.BundlePath;
		}
	}
}