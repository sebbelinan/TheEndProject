using Microsoft.AspNetCore.Mvc;

namespace ProjectEnd.Pages.Data
{
    public class TheArticle
    {
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleLocation { get; set; }
    }
}