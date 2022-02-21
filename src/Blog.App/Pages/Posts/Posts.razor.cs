using Blog.App.Data.Global;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace Blog.App.Pages.Posts;

public partial class Posts
{
    private int _pageIndex;
    private int _pageSize;

    private readonly PostPage _postData = new PostPage();


    [Inject]
    public NavigationManager Nav { get; set; } = default!;

    [Inject]
    public IOptions<AppSettings> AppSettings { get; set; } = default!;

    protected override void OnInitialized()
    {
        var dto = new PostDto
        {
            Category = new CategoryDto { Name = ".NET Core" },
            Comments = 11,
            CreateTime = DateTime.Parse("2021-07-10T20:58:27"),
            Hits = 12,
            Id = 1,
            Introduction = "阿里云ECS CentOS 8 安装配置Redis",
            IsTop = true,
            Subtitle = "阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis阿里云ECS CentOS 8 安装配置Redis",
            Tags = new List<TagDto>(),
            ThumbnailUrl = "https://img-blog.csdnimg.cn/20200701115554772.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM1MTQwNzI4,size_16,color_FFFFFF,t_70",
            Title = "阿里云ECS CentOS 8 安装配置Redis",
            TitleColor = "#BBFFFF",
            Url = "/2020/07/06/blog",
            User = new UserDto
            {
                AvatarUrl = "https://avatars.githubusercontent.com/u/33112476?v=4",
                Username = "Memoyu",
                Id = 1,
                UserId = "33112476",
            }
        };
        _pageIndex = 1;
        _pageSize = 3;

        // var a = AppSettings.Value;

        _postData.Items = new List<PostDto>();

        for (int i = 0; i < 9; i++)
        {
            var newD = JsonSerializer.Deserialize<PostDto>(JsonSerializer.Serialize(dto));
            newD.Id = i + 1;
            _postData.Items.Add(newD);
        }
        _postData.Total = 18;
    }

    private void NavigateToDetails(long id)
    {
        Nav.NavigateTo($"post/detail/{id}");
    }
}

