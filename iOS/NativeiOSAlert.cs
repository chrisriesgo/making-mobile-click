using System;
using UIKit;
using Foundation;

namespace Demo.iOS
{
	public class NativeiOSAlert : IAlert
	{
		public void ShowAlert(string message)
		{
			var appName = NSBundle
				.MainBundle
				.InfoDictionary["CFBundleDisplayName"]
				.ToString();

			var alert = new UIAlertView(
				appName, 
				message, 
				null, 
				Constants.AlertButtonText, 
				null
			);
			alert.Show();
		}
	}
}

