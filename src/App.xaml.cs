using FreshMvvm.Maui;
using HelloFreshMauiPreview.Features.Quote;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace HelloFreshMauiPreview
{
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var page = FreshPageModelResolver.ResolvePageModel<QuoteListPageModel>();
		var basicNavContainer = new FreshNavigationContainer(page);
		MainPage = basicNavContainer;
	}
}
}
