using System;
using Android.Content;
using Android.App;

namespace Demo.Droid
{
	public class NativeAndroidAlert : IAlert
	{
		public void ShowAlert(string message)
		{
			var context = DemoApplication.CurrentActivity;
			var appName = context.ApplicationInfo.NonLocalizedLabel.ToString();

			var alert = new AlertDialog.Builder(context);
			alert.SetTitle(appName);
			alert.SetCancelable(true);
			alert.SetMessage(message);
			alert.SetNeutralButton(
				Constants.AlertButtonText, 
				(sender, e) => {});
			alert.Show();
		}
	}
}

