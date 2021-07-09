using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreOne.Models;

namespace NetCoreOne.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for(int i = 1; i < 11; i++) 
            {
                contents.Add(new Content { Id = i, Title = $"{i}的标题", Comment = $"{i}的Comment", Status = 1, CreateTime = DateTime.Now.AddDays(-i) });
            }
            return View(new ContentViewModel { Contents = contents});
        }
    }
}
