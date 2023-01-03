using Core.DTOs;

namespace Core.Services
{
    public interface IGetArticleTopicsService
    {
        public Task<IEnumerable<ArticleDTO>> GetArticleTopicsAsync(string topicQuestion = "");
    }
}
