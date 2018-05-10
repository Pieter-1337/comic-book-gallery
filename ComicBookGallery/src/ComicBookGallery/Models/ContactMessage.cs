using System;
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

        public DateTime Date { get; set; }

        public int ContactMessageId { get; set; }

        public string Naam { get; set; }

        public string Email { get; set; }

        public ContactPersoonEnum ContactPersoon { get; set; }

        public string Telefoon { get; set; }

        public string Boodschap { get; set; }


    }
}