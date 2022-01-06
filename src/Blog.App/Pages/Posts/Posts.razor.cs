using Microsoft.AspNetCore.Components;

namespace Blog.App.Pages.Posts;

public partial class Posts
{
    [Inject]
    public NavigationManager Nav { get; set; } = default!;

    private void NavigateToDetails(Guid id)
    {
        Nav.NavigateTo($"post/details/{id}");
    }
}

