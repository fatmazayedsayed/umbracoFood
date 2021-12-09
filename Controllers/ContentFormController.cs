using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using umbracoFood.Models;

namespace umbracoFood.Controllers
{
    public class ContentFormController:SurfaceController
    {
        [HttpPost]
        public ActionResult SubmitForm(ContentFormModel model)
        {
            MailMessage mail = new MailMessage(model.Email, "fatam.sayed@gbrands.com");
            mail.Subject = model.Subject;
            mail.Body = model.Message;

            SmtpClient smtpClient= new SmtpClient("127.0.0.1",25);
            smtpClient.Send(mail);

            return RedirectToCurrentUmbracoPage();

        }
    }
}