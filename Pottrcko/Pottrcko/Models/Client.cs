using Pottrcko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Potrcko.Models
{
    public class Client
    {
        public Client()
        {
            Ads = new List<Ad>();

        }
        [Display(Name = "Слика")]
        
        public string ImageURL { get; set; }
        public int ClientID { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name="Име")]
        
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Презиме")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Е-маил")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9]*[@][a-z]*[.][a-z]*$")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [Required]
        [Display(Name="Град")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Телефонски број")]
        [RegularExpression("^(0|[+]389)7[^34] [0-9]{3} [0-9]{3}$", ErrorMessage ="Невалиден внес на телефонски број!")]
        public string PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Број на трансакциска сметка")]
        [RegularExpression("^(210)[0-9]{12}", ErrorMessage = "Невалиден внес на трансакциска  сметка ")]

        public string TransactionNumber { get; set; }

        [Required]
        [Display(Name="Банка")]
        public string Bank { get; set; }



        [Display(Name = "Просечна оцена")]
        public float Rating { get; set; }

        public  virtual ICollection<Ad> Ads { get; set; }
        public virtual ICollection<ClosedAd> ClosedAds { get; set; }

        public List<Ad> MyProperty { get; set; }
    }
}