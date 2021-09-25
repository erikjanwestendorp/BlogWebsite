using BlogWebsite.Data.Models.ModelsBuilder;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace BlogWebsite.Business.Services
{
    public interface INavigationService
    {
        IEnumerable<MenuItem> GetNavigation();
    }
}
