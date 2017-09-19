using System;
using Xamarin.Forms;
using ESCL.Android;

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace ESCL.Android 
{
	public class BaseUrl_Android : IBaseUrl 
	{
		public string Get () 
		{
			return "file:///android_asset/";
		}
	}
}