using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Potrcko.Models
{
    public class Ad
    {
        public Ad()
        {
            Clients = new List<Client>();
            AvailableTime = new List<string>();
        }
        public int AdID { get; set; }

        [Display(Name="Цена")]
        public float Price { get; set; }

        [Display(Name = "Име на оглас")]
        [Required]
        public string Name { get; set; }

        // oglasuvac
        public Client Owner { get; set; }

        // pobaruvaci na oglasot
        public virtual ICollection<Client> Clients { get; set; }

        [Display(Name="Опис")]
        [MinLength(40)]
        [MaxLength(200)]
        public string Description { get; set; }

        [Display(Name="Потребно време за извршување на огласот")]
        public string Duration { get; set; }

        [Display(Name="Град")]
        public string City { get; set; }

        public List<String> AvailableTime { get; set; }
        // dali da se napravat dva posebni vida na ad klasata? -
        //  ne, poradi toa sto stanuva zbor samo za edno bool svojstvo odnosno dali oglasot e namenet za povekje korisnici,
        //  dokolku ne, istiot se zatvara, dodeka ne bide izvrsen

        public bool MultipleUsers { get; set; }
    }
}