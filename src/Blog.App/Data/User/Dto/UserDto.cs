namespace Blog.App.Data;

public class UserDto
{
   public long Id { get; set; }

   public string? UserId{ get; set; }

   public int UserType{ get; set; }

   public string? UserTypeName{ get; set; }

   public string? AvatarUrl{ get; set; }

   public string? UserUrl{ get; set; }

   public string? Username{ get; set; }

   public string? Nickname{ get; set; }

   public string? Company{ get; set; }

   public string? Location{ get; set; }

   public string? Email{ get; set; }

   public string? Bio{ get; set; }

   public DateTime CreateTime { get; set; }
}
