using System;
using System.ComponentModel.DataAnnotations;

namespace ItRequitment.Core.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int UserId { get; protected set; }
               
        [Display(Name ="Podaj login")]
        [Required(ErrorMessage = "Musisz podać login")]
        [MinLength(3), MaxLength(10)]
        public string Login { get;  set; }

        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Phone { get;  set; }
        
        [Required(ErrorMessage ="Podaj adres Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get;  set; }

        [Display(Name = "Imie : ")]
        [Required(ErrorMessage ="Podaj swoje imie")]
        public string Name { get;  set; }

        [Display(Name = "O sobie")]
        [DataType(DataType.MultilineText)]
        public string Description { get;  set; }

        [Display(Name = "Nazwisko : ")]
        [Required(ErrorMessage ="Podaj swoje nazwisko"), MinLength(3), MaxLength(15),]
        public string LastName { get; set; }

        [Display(Name = "Hasło : ")]
        [Required, DataType(DataType.Password)]
        public string Password { get;  set; }

        [Display(Name = "Powtórz hasło : ")]
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get;  set; }

        [Display(Name = "Adres zamieszkania : ")]
        public string Addres { get;  set; }

        [ScaffoldColumn(false)]
        public DateTime CreationDate { get;  set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get;  set; }

    }
}