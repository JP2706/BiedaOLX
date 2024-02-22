using BiedaOLX.Core.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BiedaOLX.Core.Models.Domains
{
    public class Announcement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Tytuł jest wymagane.")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Pole Treść jest wymagane.")]
        [Display(Name = "Treść")]
        public string Body { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Pole Ulica jest wymagane.")]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Pole Kod Pocztowy jest wymagane.")]
        [Display(Name = "Kod Pocztowy")]
        [MaxLength(10)]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Pole Numer jest wymagane.")]
        [Display(Name = "Numer Budynku")]
        public string StreetNumer { get; set; }

        [Required(ErrorMessage = "Pole Miasto/Miejscowość jest wymagane.")]
        [Display(Name = "Miasto/Miejscowość")]
        public string City { get; set; }

        //[Required(ErrorMessage = "Pole Cena jest wymagane.")]
        [Display(Name = "Cena")]
        public int Value { get; set; }

        [Required(ErrorMessage = "Pole Stan jest wymagane.")]
        [Display(Name = "Stan")]
        public int NotOrUsedId { get; set; }

        //[Required(ErrorMessage = "Pole Kategoria jest wymagane.")]
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }

		//[Required(ErrorMessage = "Zdjęcie jest wymagane.")]
		[Display(Name = "Zdjęcie")]
        public string ImageFile { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public Category Category { get; set; }
        public NotOrUsed NotOrUsed { get; set; }
        
    }
}
