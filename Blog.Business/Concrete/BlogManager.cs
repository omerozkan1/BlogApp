﻿using Blog.Business.Interfaces;
using Blog.Concrete;
using Blog.DataAccess.Interfaces;
using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class BlogManager : GenericManager<Blog.Entities.Concrete.Blog>,IBlogService
    {
        private readonly IGenericDal<Blog.Entities.Concrete.Blog> _genericDal;
        private readonly IGenericDal<CategoryBlog> _categoryBlogService;
        private readonly IBlogDal _blogDal;
        public BlogManager(IGenericDal<Blog.Entities.Concrete.Blog> genericDal, IGenericDal<CategoryBlog> categoryBlogService,IBlogDal blogDal) : base(genericDal)
        {
            _blogDal = blogDal;
            _categoryBlogService = categoryBlogService;
            _genericDal = genericDal;
        }

        public async Task<List<Blog.Entities.Concrete.Blog>> GetAllSortedByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(I => I.PostedTime);
        }

        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var control = await _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId && I.BlogId == categoryBlogDto.BlogId);
            if (control == null)
            {
                await _categoryBlogService.AddAsync(new CategoryBlog
                {
                    BlogId = categoryBlogDto.BlogId,
                    CategoryId = categoryBlogDto.CategoryId
                });
            }
           
        }
        public async Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
           var deletedCategoryBlog=  await  _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId && I.BlogId == categoryBlogDto.BlogId);
            if (deletedCategoryBlog != null)
            {
                await _categoryBlogService.RemoveAsync(deletedCategoryBlog);
            }                    
        }

        public async Task<List<Blog.Entities.Concrete.Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            return await _blogDal.GetAllByCategoryIdAsync(categoryId);
        }

        public async Task<List<Category>> GetCategoriesAsync(int blogId)
        {
            return await _blogDal.GetCategoriesAsync(blogId);
        }

        public async Task<List<Blog.Entities.Concrete.Blog>> GetLastFiveAsync()
        {
            return await _blogDal.GetLastFiveAsync();
        }

        public async Task<List<Blog.Entities.Concrete.Blog>> SearchAsync(string searchString)
        {
           return await _blogDal.GetAllAsync(I => I.Title.Contains(searchString) || I.ShortDescription.Contains(searchString) || I.Description.Contains(searchString), I => I.PostedTime);
        }
    }
}
