using Microsoft.AspNetCore.Components;

namespace Blog.App.Data.Global;

public class NavHelper
{
    private NavigationManager _navigationManager;

    public List<NavModel> Navs = new List<NavModel>
    {
        new NavModel(1, "/post", "mdi-file-certificate-outline", "文章"),
        new NavModel(2, "/tag", "mdi-tag-outline", "标签"),
        new NavModel(3, "/link", "mdi-link", "友链"),
        new NavModel(4, "/other", "mdi-dots-horizontal-circle-outline", "其他"),
    };

    public NavHelper(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void NavigateTo(NavModel nav)
    {
        Active(nav);
        _navigationManager.NavigateTo(nav.Href ?? "");
    }

    public void NavigateTo(string href)
    {
        var nav = Navs.FirstOrDefault(n => n.Href == href);
        Active(nav);
        _navigationManager.NavigateTo(href);
    }

    public void Active(NavModel? nav)
    {
        Navs.ForEach(n => n.Active = false);
        if (nav is not null) nav.Active = true;
    }
}
