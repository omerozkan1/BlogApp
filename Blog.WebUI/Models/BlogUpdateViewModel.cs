﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Models
{
    public class BlogUpdateViewModel
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir.")]
        [Display(Name = "Başlık :")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Kısa Açıklama alanı gereklidir.")]
        [Display(Name = "Kısa Açıklama :")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        [Display(Name = "Açıklama :")]
        public string Description { get; set; }

        [Display(Name = "Resim Seçiniz :")]
        public IFormFile Image { get; set; }
    }
}
