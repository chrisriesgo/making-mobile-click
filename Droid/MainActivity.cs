
using Android.App;
using Android.Widget;
using Android.OS;

namespace Demo.Droid
{
	[Activity(Label = "MCC Demo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		ViewModel viewModel;
		public MainActivity()
		{	
			viewModel = new ViewModel();
		}

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
			DemoApplication.CurrentActivity = this;

			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += async delegate {

				// Asynchronous programming w/C# is this easy

				button.Text = await viewModel.GetTextAsync();
			};
		}
	}
}


