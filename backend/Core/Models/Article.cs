using Core.Enums;

namespace Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public string Body { get; set; }
        public string ContentSource { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlBytes { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
