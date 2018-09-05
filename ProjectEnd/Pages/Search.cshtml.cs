using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectEnd.Pages.Data;

namespace ProjectEnd.Pages
{

    public class SearchModel : PageModel
    {
        private ArcturusContext Context;
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleLocation { get; set; }
        public List<TheArticle> TheArticles { get; set; }

        public SearchModel(ArcturusContext context)
        {
            this.Context = context;
        }

        /*public async Task OnGetSeekAsync(string Search) //Add functionality to include not exact searches, give suggestions?
        {
            var quest = from s in Context.TheArticle
                        select s;
            if (!string.IsNullOrEmpty(Search.ToLower()))
            {
                quest = quest.Where(q => q.ArticleName.ToLower().SequenceEqual(Search));
                TheArticles = await quest.ToListAsync();
            }
            
        }*/

        public IActionResult OnGet(string Search)
        {
            var quest = from s in Context.TheArticle
                        select s;
            if (!string.IsNullOrEmpty(Search.ToLower()))
            {
                quest = quest.Where(q => q.ArticleName.ToLower().SequenceEqual(Search));
                TheArticles = quest.ToList();
                /*if(TheArticles.Count == 0)
                {
                    quest = quest.Where(q => q.ArticleName.ToLower().com)
                }*/
            }
            return Page();
        }
    }
}