using FreshMvvm.Maui;
using HelloFreshMauiPreview.Features.Quote;

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