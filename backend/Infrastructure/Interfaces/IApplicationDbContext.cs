using Core.DTOs;
using Core.Models;

namespace Ìnfrastructure.Interfaces
{
    public interface IArticleRepository
    {
        public RepositoryResult SaveArticles(IEnumerable<Article> articles);
        public RepositoryResult GetArticles();
    }
}
