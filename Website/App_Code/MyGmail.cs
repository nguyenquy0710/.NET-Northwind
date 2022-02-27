using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
public class MyGmail
{
    static public bool ValidateEmail(string email)
    {
        string emailRegex = @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$";
        Regex re = new Regex(emailRegex);
        return re.IsMatch(email);
    }

    static public bool Send(string to, string sub, string body, string attFile)
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("laptrinhvien.1005@gmail.com");
        msg.To.Add(to);
        msg.Subject = sub;
        msg.Body = body;
        if (!string.IsNullOrEmpty(attFile) && File.Exists(attFile))
        {
            Attachment att = new Attachment(attFile);
            msg.Attachments.Add(att);
        }
        //msg.Priority = MailPriority.High;

        using (SmtpClient client = new SmtpClient())
        {
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("laptrinhvien.1005@gmail.com", "01203119422");//mail ca duoc cho phap dang nhap boi cac phien khong an toan
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(msg);
                return true;
            }
            catch(Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                return false;
            }
        }
    }
}