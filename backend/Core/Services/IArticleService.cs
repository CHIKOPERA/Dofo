using Core.Models;

namespace Core.Services
{
    public interface IArticleService
    {
        public IEnumerable<Article> GetArticles();

        public void SaveArticles(IEnumerable<Article> articles);

        public void GenerateNewArticles();
    }
}
