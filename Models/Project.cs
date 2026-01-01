using Microsoft.AspNetCore.Mvc;

namespace Gemark_Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GitHubUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}

