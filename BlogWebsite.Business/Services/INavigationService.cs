using BlogWebsite.Data.Models.ModelsBuilder;
using System.Collections.Generic;

namespace BlogWebsite.Business.Services
{
    public interface INavigationService
    {
        Home GetHome();
        IEnumerable<MenuItem> GetNavigation();
    }
}
