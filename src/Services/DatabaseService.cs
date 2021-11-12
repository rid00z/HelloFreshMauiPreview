using System;
using System.Collections.Generic;
using HelloFreshMauiPreview.Features.Quote;

namespace HelloFreshMauiPreview.Services
{
    public class DatabaseService : IDatabaseService
    {
        private List<Quote> _quotes;

        public DatabaseService()
        {
            _quotes = InitQuotes();
        }

        public void UpdateQuote(Quote quote)
        {
            if (quote.Id == 0)
            {
                quote.Id = _quotes.Count + 1;
                _quotes.Add(quote);
            }
            else
            {
                var oldQuote = _quotes.Find(c => c.Id == quote.Id);
                oldQuote.CustomerName = quote.CustomerName;
                oldQuote.Total = quote.Total;
            }
        }

        public List<Quote> GetQuotes()
        {
            return _quotes;
        }

        private List<Quote> InitQuotes()
        {
            return new List<Quote> {
                new Quote { Id = 1, CustomerName = "Xam Consulting", Total = "$350.00" },
                new Quote { Id = 2, CustomerName = "Michael Ridland", Total = "$3503.00" },
                new Quote { Id = 3, CustomerName = "Thunder Apps", Total = "$3504.00" },
            };
        }
    }
}

