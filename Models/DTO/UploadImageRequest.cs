using Microsoft.AspNetCore.Http;

namespace CodePulseAPI.Models.DTO
{
    public class UploadImageRequest
    {
        public IFormFile File { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}