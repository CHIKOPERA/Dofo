using Core.DTOs;
using Core.Models;
using Ìnfrastructure.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ArticleRepository(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public RepositoryResult GetArticles()
        {
            try
            {
                var articles = _applicationDbContext.Articles.ToList();
                return new RepositoryResult()
                {
                    IsSuccessfull = true,
                    Articles = articles

                };
            }
            catch (Exception ex)
            {
                return new RepositoryResult()
                {
                    IsSuccessfull = false,
                    ErrorMessage = ex.Message

                };
            }
        }

        public RepositoryResult SaveArticles(IEnumerable<Article> articles)
        {

            try
            {
                _applicationDbContext.Articles.AddRange(articles);
                _applicationDbContext.SaveChanges();
                return new RepositoryResult()
                {
                    IsSuccessfull = true,
                };

            }
            catch (Exception ex)
            {

                return new RepositoryResult()
                {
                    IsSuccessfull = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
