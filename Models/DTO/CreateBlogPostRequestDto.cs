namespace CodePulseAPI.Models.DTO
{
    public class CreateBlogPostRequestDto
    {
        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string FeaturedImageUrl { get; set; } = null!;
        public string UrlHandle { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; } = null!;
        public bool IsVisible { get; set; }
        public Guid[] Categories { get; set; }
    }
}
