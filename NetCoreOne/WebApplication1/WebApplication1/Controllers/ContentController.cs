using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option) 
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for(int i = 1; i < 11; i++) 
            //{
            //    contents.Add(new Content { Id = i, Title = $"{i}的标题", Comment = $"{i}的内容", Status = 1, CreateOn = DateTime.Now.AddDays(-i) });
            //}
            //return View(new ContentViewModel { Contents = contents });
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}
