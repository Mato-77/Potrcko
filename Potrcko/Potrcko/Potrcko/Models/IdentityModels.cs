using System.Collections.Generic;
using Potrcko.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Potrcko.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string ImageURL { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Име")]

        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Презиме")]
        public string Surname { get; set; }


        [Required]
        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Град")]
        public string City { get; set; }



        [Required]
        [Display(Name = "Број на трансакциска сметка")]
        [RegularExpression("^(210)[0-9]{12}", ErrorMessage = "Невалиден внес на трансакциска  сметка ")]

        public string TransactionNumber { get; set; }

        [Required]
        [Display(Name = "Банка")]
        public string Bank { get; set; }



        [Display(Name = "Просечна оцена")]
        public float Rating { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }
        public virtual ICollection<ClosedAd> ClosedAds { get; set; }

        public List<Ad> ActiveAds { get; set; }

        public List<Ad> ReservedAds { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Ad> Ads { get; set; }

        public DbSet<ClosedAd> ClosedAds { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}