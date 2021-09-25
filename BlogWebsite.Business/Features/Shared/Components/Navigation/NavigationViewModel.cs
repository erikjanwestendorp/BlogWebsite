using BlogWebsite.Data.Models.ModelsBuilder;
using System.Collections.Generic;

namespace BlogWebsite.Business.Features.Shared.Components.Navigation
{
    public class NavigationViewModel
    {
        public IEnumerable<MenuItem> Items { get; set; }
    }
}
