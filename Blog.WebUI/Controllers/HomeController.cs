﻿using System.Threading.Tasks;
using Blog.WebUI.ApiServices.Interfaces;
using Blog.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogApiService _blogApiService;
        private readonly IimageApiService _imageApiService;
        public HomeController(IBlogApiService blogApiService, IimageApiService imageApiService)
        {
            _blogApiService = blogApiService;
            _imageApiService = imageApiService;
        }
        public async Task<IActionResult> Index(int? categoryId,string s)
        {
            if (categoryId.HasValue)
            {
                ViewBag.ActiveCategory = categoryId;
                return View(await _blogApiService.GetAllByCategoryIdAsync((int)categoryId));
            }

            if (!string.IsNullOrWhiteSpace(s))
            {
                ViewBag.SearchString = s;
                return View(await _blogApiService.SearchAsync(s));
            }

            return View(await _blogApiService.GetAllAsync());
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.Comments = await _blogApiService.GetCommentsAsync(id, null);
            return View(await _blogApiService.GetByIdAsync(id));
        }

        public async Task<IActionResult> AddToComment(CommentAddViewModel model)
        {
            await _blogApiService.AddToComment(model);
            return RedirectToAction("BlogDetail", new { id = model.BlogId });
        }
    }
}