using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectEnd.Pages.Data;

namespace ProjectEnd.Pages
{
    public class IndexModel : PageModel
    {
        private ArcturusContext Context;
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleLocation { get; set; }
        public List<TheArticle> TheArticles{ get; set; }

        public IndexModel(ArcturusContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        public void OnGet()
        {
            TheArticles = Context.TheArticle.ToList();
        }
    }
}
