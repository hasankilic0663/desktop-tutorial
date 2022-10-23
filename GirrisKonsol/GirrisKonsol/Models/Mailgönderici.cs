using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using GirrisKonsol.Models;
namespace GirrisKonsol.Models
{
    class Mailgönderici
    {
        Giris1EntitiesConnectionDb db = new Giris1EntitiesConnectionDb();
        public void Microsoft( string GondericiMail, string GondericiPass, string AliciMail)
        {
            GirisBilgileri p = db.GirisBilgileri.FirstOrDefault(x => x.e_mail == GondericiMail);
            Random rnd = new Random();
            
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "Oturum Açma Örnek projesi ");
            mail.To.Add(AliciMail);
            mail.Subject ="Şifre sıfırlama talebinde bulundunuz.";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre sıfırlama talebinde bulundunuz.Unuttuğunuz Şifre:{p.sifre}" ;
           
           // sc.Timeout = 100;
            sc.Send(mail);
        }
    }
}
