﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBRepository;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleBlog.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [Route("page")]
        [HttpGet]
        public async Task<Page<Post>> GetPosts(int pageIndex, string tag)
        {
            return await _blogRepository.GetPosts(pageIndex, 10, tag);
        }
    }
}
