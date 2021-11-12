using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace HelloFreshMauiPreview
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}