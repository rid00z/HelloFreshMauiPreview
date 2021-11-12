using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Extensions.DependencyInjection;
using HelloFreshMauiPreview.Services;
using HelloFreshMauiPreview.Features.Quote;
using FreshMvvm.Maui.Extensions;

namespace HelloFreshMauiPreview
{
	public static class MauiProgram
	{
	    public static MauiApp CreateMauiApp()
	    {
		    var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.Add(ServiceDescriptor.Singleton<IDatabaseService, DatabaseService>());

            builder.Services.Add(ServiceDescriptor.Transient<QuoteListPage, QuoteListPage>());
            builder.Services.Add(ServiceDescriptor.Transient<QuotePage, QuotePage>());

            builder.Services.Add(ServiceDescriptor.Transient<QuoteListPageModel, QuoteListPageModel>());
            builder.Services.Add(ServiceDescriptor.Transient<QuotePageModel, QuotePageModel>());

            builder.Services.UseFreshMvvm();

            return builder.Build();
        }
	}
}