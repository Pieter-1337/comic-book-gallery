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


        //Rerturnt alle contact messages
        public List<ContactMessage> getContactMessages()
        {
            return _contactMessages;
        }

        //Returnt een specifieke contact message op id
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

        public void DeleteContactMessage(int id)
        {
            //Find the id of the message we want to remove
            int messageIndex = _contactMessages.FindIndex(e => e.ContactMessageId == id);

            if(messageIndex == -1)
            {
                throw new Exception(string.Format("Unable to find a contact message with id {0}", id));
            }

            _contactMessages.RemoveAt(messageIndex);
        }
    }
}