using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ContactController : Controller
    {
        private ContactMessageRepository _contactMessageRepository = null;

        public ContactController()
        {
            _contactMessageRepository = new ContactMessageRepository();
        }


        //Wanneer de pagina eerste maal wordt gegenereerd in de sessie
        // GET: Contact
        
        public ActionResult Index()
        {
            
            var contactMessage = new ContactMessage()
            {
                Date = DateTime.Today
            };
            return View(contactMessage);
        }

        //Wanneer er een Post van de form (een nieuwe contactmessage wordt verstuurd) wordt uitgevoerd of wanneer de modelstate niet Valid is
        [HttpPost]
        public ActionResult Index(ContactMessage contactMessage)
        {


            
            if (ModelState.IsValid)
            {
                // Get the next available Message ID.
                int nextAvailableEntryId = ContactMessageRepository._contactMessages
                    .Max(e => e.ContactMessageId) + 1;

                contactMessage.ContactMessageId = nextAvailableEntryId;

                ContactMessageRepository._contactMessages.Add(contactMessage);
                return RedirectToAction("ContactMessages");
            }
            return View(contactMessage);
        }

        //Alle contact messages opgelijst
        public ActionResult ContactMessages()
        {
            var contactMessages = _contactMessageRepository.getContactMessages();
            return View(contactMessages);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var contactMessage = _contactMessageRepository.GetContactMessage(id.Value);
                
            return View(contactMessage);
        }

        public ActionResult Delete (int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int messageId = Convert.ToInt32(id);

            _contactMessageRepository.DeleteContactMessage(messageId);

            return RedirectToAction("ContactMessages");

        }


    }
}