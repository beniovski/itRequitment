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
        public int CompanyId { get; protected set; }

        [Required(ErrorMessage ="Podaj login"), MinLength(3), MaxLength(10)]
        public string Login { get; protected set; }

        [Phone]
        public string Phone { get; protected set; }

        [Required, MinLength(3), MaxLength(10)] 
        [DataType(DataType.EmailAddress, ErrorMessage = "Adres email niepoprawny")]
        public string Email { get; protected set; }

        public string Description { get; protected set; }

        [DataType(DataType.Password)]
        public string Password { get; protected set; }

        [DataType(DataType.Password), Compare(nameof(Password),ErrorMessage = "Hasła nie są takie same")]
        public string ConfirmPassword { get; protected set; }

        [Required(ErrorMessage ="Podaj adres fimry")]
        public string Addres { get; protected set; }

        public DateTime CreationDate { get; protected set; }

       // public JobOffer Offer { get; protected set; }

       // public IEnumerable<JobOffer> AllOffer { get; protected set; }
    }
}