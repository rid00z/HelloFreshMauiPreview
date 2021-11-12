using System;
using PropertyChanged;

namespace HelloFreshMauiPreview.Features.Quote
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class Quote
    {
        public Quote()
        {
        }
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Total { get; set; }
    }
}
