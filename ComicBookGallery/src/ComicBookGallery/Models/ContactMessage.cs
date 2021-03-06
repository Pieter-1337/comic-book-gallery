﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ComicBookGallery.Models
{
    public class ContactMessage
    {
        public enum ContactPersoonEnum
        {
            Particulier,
            Bedrijf
        }

        //Constructor no params
        public ContactMessage()
        {

        }

        public ContactMessage(DateTime date ,int contactMessageId, string naam, string email, ContactPersoonEnum contactPersoon, string telefoon, string boodschap)
        {
            Date = date;
            ContactMessageId = contactMessageId;
            Naam = naam;
            Email = email;
            ContactPersoon = contactPersoon;
            Telefoon = telefoon;
            Boodschap = boodschap;

        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve een correcte datum in te vullen.")]
        public DateTime Date { get; set; }

        public int ContactMessageId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve het Naam veld in te vullen.")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Gelieve enkel tekens uit het alfabet te gebruiken om u naam in te vullen")]
        public string Naam { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve het Email veld in te vullen.")]
        [EmailAddress(ErrorMessage = "Gelieve een correct email adres in te vullen.")]
        public string Email { get; set; }

        public ContactPersoonEnum ContactPersoon { get; set; }

        
        public string Telefoon { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve een Boodschap in te vullen")]
        public string Boodschap { get; set; }


    }
}