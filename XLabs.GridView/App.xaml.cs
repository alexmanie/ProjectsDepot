using Xamarin.Forms;

namespace XLabs.GridView
{
    public partial class App : Application
    {
        public App()
        {
            try
			{
                InitializeComponent();

				MainPage = new GridViewPage();
			}
			catch (System.Exception ex)
			{

			}
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
