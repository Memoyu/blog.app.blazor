namespace Blog.App.Data;

public class PostDto
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? TitleColor { get; set; }

    public string? Subtitle { get; set; }

    public string? Introduction { get; set; }

    public UserDto? User { get; set; }

    public string? Url { get; set; }

    public bool IsTop { get; set; }

    public int Hits { get; set; }

    public int Comments { get; set; }

    public string? ThumbnailUrl { get; set; }

    public CategoryDto? Category { get; set; }

    public List<TagDto>? Tags { get; set; }

    public DateTime CreateTime { get; set; }
}

