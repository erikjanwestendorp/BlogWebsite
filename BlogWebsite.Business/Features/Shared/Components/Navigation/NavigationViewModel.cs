using BlogWebsite.Data.Models.ModelsBuilder;
using System.Collections.Generic;

namespace BlogWebsite.Business.Features.Shared.Components.Navigation
{
    public class NavigationViewModel
    {
        public Home Home { get; set; }
        public IEnumerable<MenuItem> Items { get; set; }
    }
}
