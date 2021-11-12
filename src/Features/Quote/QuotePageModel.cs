using Microsoft.Maui.Controls;
using FreshMvvm.Maui;
using HelloFreshMauiPreview.Services;

namespace HelloFreshMauiPreview.Features.Quote
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class QuotePageModel : FreshBasePageModel
    {
        IDatabaseService _databaseService;

        public Quote Quote { get; set; }

        public QuotePageModel(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Command SaveCommand
        {
            get
            {
                return new Command(async () => {
                    _databaseService.UpdateQuote(Quote);
                    await CoreMethods.PopPageModel(Quote);
                });
            }
        }

        public Command TestModal
        {
            get
            {
                return new Command(async () => {
                    
                });
            }
        }
    }
}

