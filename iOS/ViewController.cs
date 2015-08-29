using System;
using UIKit;

namespace Demo.iOS
{
	public partial class ViewController : UIViewController
	{
		ViewModel viewModel;
		public ViewController(IntPtr handle) : base(handle)
		{		
			viewModel = new ViewModel();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			#region Initialize Xamarin.UITest...
			// Code to start the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
			#endif

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			#endregion

			Button.TouchUpInside += async delegate {
				
				// Asynchronous programming w/C# is this easy

				var title = await viewModel.GetTextAsync();
				Button.SetTitle(title, UIControlState.Normal);
			};
		}
	}
}
