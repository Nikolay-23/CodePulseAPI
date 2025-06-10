namespace CodePulseAPI.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string UrlHandle { get; set; } = null!;
    }
}
