namespace CodePulseAPI.Models.DTO
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string UrlHandle { get; set; } = null!;
    }
}
