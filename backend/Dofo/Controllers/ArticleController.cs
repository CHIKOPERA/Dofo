using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dofo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public IEnumerable<Article> Get()
        {
            _articleService.GenerateNewArticles();
            return _articleService.GetArticles();
        }
    }
}
