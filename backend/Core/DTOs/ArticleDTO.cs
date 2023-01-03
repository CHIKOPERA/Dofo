using Core.Enums;

namespace Core.DTOs
{
    public class ArticleDTO
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public string Body { get; set; }
        public string ContentSource { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlBytes { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
