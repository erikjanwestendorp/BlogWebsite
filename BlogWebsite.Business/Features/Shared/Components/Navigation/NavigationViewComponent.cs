using BlogWebsite.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Business.Features.Shared.Components.Navigation
{
    [ViewComponent(Name = "Navigation")]
    public class NavigationViewComponent : ViewComponent
    {
        private readonly INavigationService _navigationService;

        public NavigationViewComponent(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new NavigationViewModel
            {
                Items = _navigationService.GetNavigation()
            });
        }
    }
}
