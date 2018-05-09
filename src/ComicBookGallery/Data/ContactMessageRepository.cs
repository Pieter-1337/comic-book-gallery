using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;


namespace ComicBookGallery.Data
{
    public class ContactMessageRepository
    {
        public static List<ContactMessage> _contactMessages = new List<ContactMessage>()
        {
            new ContactMessage
            {
                ContactMessageId = 1,
                Date = DateTime.Today,
                Naam = "Pieter Bracke",
                Email = "Pieterbracke@msn.com",
                ContactPersoon = ContactMessage.ContactPersoonEnum.Particulier,
                Telefoon = "0472321708",
                Boodschap = "Eerste contact message bericht"
            }
        };

        public List<ContactMessage> getContactMessages()
        {
            return _contactMessages;
        }

        public ContactMessage GetContactMessage(int id)
        {
            ContactMessage ContactMessageToReturn = null;

            foreach(ContactMessage message in _contactMessages)
            {
                if(message.ContactMessageId == id)
                {
                    ContactMessageToReturn = message;
                    break;
                }
            }

            return ContactMessageToReturn;
        }
    }
}