
using Xamarin.Forms;

namespace XFEventToCommandBehavior.Sample
{
	public class App : Application
	{
		public App()
		{
			MainPage = new Views.MainPage();
			XFEventToCommandBehavior.Library.Init();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

