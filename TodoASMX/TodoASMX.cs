using TodoASMX.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace TodoASMX
{
	public class App : Application
	{
		public static TodoItemManager TodoManager { get; set; }

		public App ()
		{
			MainPage = new NavigationPage(new Welcome())
			{
				BarBackgroundColor = Color.FromHex("#d9d9d9"),
				BarTextColor = Color.FromHex("#fff")
			};

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
