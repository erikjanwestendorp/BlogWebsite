using System.Linq;
using System.Collections.Generic;
using Umbraco.Cms.Web.Common;
using BlogWebsite.Data.Models.ModelsBuilder;
using Umbraco.Extensions;

namespace BlogWebsite.Business.Services.Implementation
{
    public class NavigationService : INavigationService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public NavigationService(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public Home GetHome()
        {
            var root = _umbracoHelper.ContentAtRoot().FirstOrDefault(x => x.ContentType.Alias == Home.ModelTypeAlias);

            if (root is Home home)
                return home;

            return null;
        }

        public IEnumerable<MenuItem> GetNavigation()
        {
            var menu = _umbracoHelper.ContentAtRoot()
                .FirstOrDefault(x => x.ContentType.Alias == Home.ModelTypeAlias)
                ?.FirstChild<Settings>()
                ?.FirstChild<Menu>();

            return menu != null ? menu.Children<MenuItem>() : Enumerable.Empty<MenuItem>();
        }
    }
}
