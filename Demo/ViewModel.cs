using System;
using System.Threading.Tasks;

namespace Demo
{
	public class ViewModel
	{
		public static int count = 1;
		public async Task<string> GetTextAsync()
		{ 
			#region Look in here...

			if(count % 5 == 0)
			{
				var alert = TinyIoC.TinyIoCContainer.Current.Resolve<IAlert>();
				alert.ShowAlert("Nice clicking!");
			}

			#endregion

			return await WorkService.GetTextAsync(count++); 
		}
	}
}

