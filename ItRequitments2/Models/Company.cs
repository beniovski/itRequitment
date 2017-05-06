using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ItRequitment.Models
{    
    public class Company
    {
        [ScaffoldColumn(false)]
        public int CompanyId { get; set; }

        [Required(ErrorMessage ="Podaj login"), MinLength(3), MaxLength(10)]
        public string Login { get;  set; }

        [Phone]
        public string Phone { get;  set; }

        [Required, MinLength(3), MaxLength(10)] 
        [DataType(DataType.EmailAddress, ErrorMessage = "Adres email niepoprawny")]
        public string Email { get;  set; }

        public string Description { get;  set; }

        [DataType(DataType.Password)]
        public string Password { get;  set; }

        [DataType(DataType.Password), Compare(nameof(Password),ErrorMessage = "Hasła nie są takie same")]
        public string ConfirmPassword { get;  set; }

        [Required(ErrorMessage ="Podaj adres fimry")]
        public string Addres { get;  set; }

        [ScaffoldColumn(false)]
        public DateTime CreationDate { get;  set; }

        public virtual ICollection<JobOffer> JobOffers { get; set; }

        public Company()
        {
            JobOffers = new HashSet<JobOffer>();
        }

       
    }
}