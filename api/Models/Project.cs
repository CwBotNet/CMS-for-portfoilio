namespace api.Models
{
    public class Project
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string projectLink { get; set; }
        public string codeLink { get; set; }

    }
}
