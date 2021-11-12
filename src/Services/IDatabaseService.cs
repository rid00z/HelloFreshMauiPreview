using System;
using System.Collections.Generic;
using HelloFreshMauiPreview.Features.Quote;

namespace HelloFreshMauiPreview.Services
{
    public interface IDatabaseService
    {
        List<Quote> GetQuotes();

        void UpdateQuote(Quote quote);
    }
}
