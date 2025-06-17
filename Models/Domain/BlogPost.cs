using Microsoft.AspNetCore.Http.HttpResults;

namespace CodePulseAPI.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = null!; 
        public string Content { get; set; } = null!;
        public string FeaturedImageUrl { get; set; } = null!;
        public string UrlHandle { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public string Author {  get; set; } = null!;
        public bool IsVisible { get; set; }

        public ICollection<Category> Categories { get; set; } 
    }
}
