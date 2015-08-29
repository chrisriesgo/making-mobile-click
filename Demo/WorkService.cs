using System;
using System.Threading.Tasks;

namespace Demo
{
	internal static class WorkService
	{
		public static async Task<string> GetTextAsync(int count)
		{
			return await Task.Run(async () =>
			{	
				#region Important business things...

				// Call out to an API

				// Save to a SQLite database

				#endregion

				return count == 1

					// Gratuitous C# 6 string interpolation demo
					? $"{count} person thinks that Xamarin is neat!"

					// The old way
					: string.Format("{0} people think that Xamarin is neat!", count);
			});
		}
	}
}

