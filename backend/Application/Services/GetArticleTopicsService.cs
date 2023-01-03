using Core.DTOs;
using Core.Services;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

namespace Application.Services
{
    // a522e3139b524b75933450172341ae9a
    public class GetArticleTopicsService : IGetArticleTopicsService
    {
        public async Task<IEnumerable<ArticleDTO>> GetArticleTopicsAsync(string topicQuestion = "What is trending in South Africa")
        {
            // init with your API key
            var newsApiClient = new NewsApiClient("a522e3139b524b75933450172341ae9a");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Q = topicQuestion,
                Language = Languages.EN,

            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                return await GetArticleTopic(articlesResponse.Articles);
            }

            return new List<ArticleDTO>();
        }

        private async Task<IEnumerable<ArticleDTO>> GetArticleTopic(IEnumerable<Article> articles)
        {
            var articleTopics = articles.Select(x => new ArticleDTO()
            {
                Title = x.Title,
                Author = x.Author,
                Url = x.Url,
                Body = x.Content,
                ImageUrl = x.UrlToImage,
                Description = x.Description,
                PublishedDate = x.PublishedAt,
                ContentSource = x.Source.Name
            });

            return articleTopics;
        }
    }
}
