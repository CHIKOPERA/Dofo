using Core.Models;
using Core.Services;
using Ìnfrastructure.Interfaces;

namespace Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IGetArticleTopicsService _getArticleTopicsService;

        public ArticleService(IArticleRepository articleRepository, IGetArticleTopicsService getArticleTopicsService)
        {
            _articleRepository = articleRepository;
            _getArticleTopicsService = getArticleTopicsService;
        }

        public async void GenerateNewArticles()
        {
            var topicAticles = await _getArticleTopicsService.GetArticleTopicsAsync();

        }

        public IEnumerable<Article> GetArticles()
        {
            var articleResult = _articleRepository.GetArticles();
            if (articleResult.IsSuccessfull)
            {
                return articleResult.Articles ?? new List<Article>();
            }
            return new List<Article>();
        }

        public void SaveArticles(IEnumerable<Article> articles)
        {
            var articleSaveResult = _articleRepository.SaveArticles(articles);
        }
    }
}
