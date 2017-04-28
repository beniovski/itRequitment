using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ItRequitment.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int CompanyId { get; protected set; }

        public Guid Id { get; protected set; }

        [Required, MinLength(3), MaxLength(10)]
        public string Login { get; protected set; }

        public string Phone { get; protected set; }

        [Required, MinLength(3), MaxLength(10)] 
        public string Email { get; protected set; }

        public string Description { get; protected set; }

        [DataType(DataType.Password)]
        public string Password { get; protected set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; protected set; }

        public string Addres { get; protected set; }

        public DateTime CreationDate { get; protected set; }

        public JobOffer Offer { get; protected set; }

        public IEnumerable<JobOffer> AllOffer { get; protected set; }
    }
}