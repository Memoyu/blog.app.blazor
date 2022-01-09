namespace Blog.App.Data.Global
{
    public class NavModel
    {
        public NavModel(int id, string href, string icon, string title)
        {
            Id = id;
            Href = href;
            Icon = icon;
            Title = title;
        }

        public int Id { get; set; }

        public string Href { get; set; }

        public string Icon { get; set; }

        public string Title { get; set; }

        public bool Hide { get; set; }

        public bool Active { get; set; }
    }
}
