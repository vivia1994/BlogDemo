using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogDemo.Models;

namespace BlogDemo.Controllers
{
    public class ArticleController : Controller
    {
        private DatabaseContext database;

        public ArticleController()
        {
            database = new DatabaseContext();
        }

        // 文章列表
        public ActionResult Index()
        {
            List<Article> articles = database.Articles.ToList();
            ViewBag.Articles = articles;
            return View();
        }

        // 文章内容
        public ActionResult Show(int articleId)
        {
            Article article = database.Articles.Find(articleId);
            ViewBag.Article = article;
            return View();
        }

        // 新建文章
        public ActionResult Insert()
        {
            return View();
        }

        // 相应新建文章提交
        public ActionResult InsertSubmit(string titel, string content)
        {
            Article newArticle = new Article();
            newArticle.Titel = titel;
            newArticle.Content = content;
            Article article = database.Articles.Add(newArticle);
            database.SaveChanges();
            ViewBag.Article = article;
            return View();
        }

        // 修改文章
        public ActionResult Update(int articleId)
        {
            Article article = database.Articles.Find(articleId);
            ViewBag.Article = article;
            return View();
        }

        // 相应修改文章提交
        public ActionResult UpdateSubmit(int articleId, string newTitel, string newContent)
        {
            Article article = database.Articles.Find(articleId);
            article.Titel = newTitel;
            article.Content = newContent;
            database.SaveChanges();
            ViewBag.Article = article;
            return View();
        }
    }
}