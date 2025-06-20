namespace CodePulseAPI.Models.DTO
{
    public class BlogImageDto
    {
        public Guid Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Url { get; set; } = null!;
        public DateTime DateCreated { get; set; }
    }
}
