using Core.Models;

namespace Core.DTOs
{
    public class RepositoryResult : BaseResult
    {
        public IEnumerable<Article>? Articles { get; set; }
    }
}
