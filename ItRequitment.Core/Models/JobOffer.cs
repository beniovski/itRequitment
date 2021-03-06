﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ItRequitment.Core.Models
{
    public class JobOffer
    {
        [ScaffoldColumn(false)]
        public int JobOfferId { get; protected set; }

        [Required(ErrorMessage = "Podaj datę początku publikacji")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; protected set; }

        [Required(ErrorMessage = "Podaj datę końca publikacji")]
        [DataType(DataType.Date)]
        public DateTime EndTime { get; protected set; }

        [Display(Name = "Stanowisko : ")]
        [Required(ErrorMessage = "Nazwa stanowiska jest wymagana")]
        [StringLength(50, ErrorMessage = "Nazwa Stanowiska nie może być dłuzsza niż 50 znaków")]
        public string Title { get; protected set; }

        [Display(Name = "Opis stanowiska")]
        public string Description { get; protected set; }

        [Display(Name = "Wymagania")]
        public string Requirements { get; protected set; }

        [Display(Name = "Zarobiki")]
        public string Salary { get; protected set; }

        [Display(Name = "Podaj miejsce pracy")]
        [Required(ErrorMessage = "Podaj miejsce pracy")]
        public string Placement { get; protected set; }

        public virtual Company Company { get; protected set; }
    }
}