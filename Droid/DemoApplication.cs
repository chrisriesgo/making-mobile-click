using System;
using Android.App;
using Android.Content;
using Android.Runtime;

namespace Demo.Droid
{
	[Application]
	public class DemoApplication : Application
	{
		public static Context CurrentActivity { get; set; }
		public DemoApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) {}

		public override void OnCreate()
		{
			base.OnCreate();

			TinyIoC.TinyIoCContainer.Current.Register<IAlert, NativeAndroidAlert>();	
		}
	}
}

