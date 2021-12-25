using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Film adı alanı boş bırakılamaz!")]
        [StringLength(50, ErrorMessage = "Film adı 50 karakterden uzun olamaz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz!")]
        public string Description { get; set; }
        public string Yonetmen { get; set; }
        public string Oyuncular { get; set; }
        [Required(ErrorMessage = "Fotoğraf alanı boş bırakılamaz!")]
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
    }
}
