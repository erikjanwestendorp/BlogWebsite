using BlogWebsite.Business.Services;
using BlogWebsite.Business.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace BlogWebsite.Business.Compose
{
    public class BusinessComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<INavigationService, NavigationService>();
        }
    }
}
