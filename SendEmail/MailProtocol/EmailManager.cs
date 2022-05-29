using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

using System.Configuration;

namespace SendEmail.MailProtocol
{
	class EmailManager
	{
		public static void SendEmail(
			string fromDisplay,
			string fromAddress,
			string encodedPassword,
			string toDisplay,
			string toAddress,
			string subject,
			StringBuilder body,
			string[] attachments
			)
		{

//			SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = "smtp-mail.outlook.com";
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;

			smtpClient.Timeout = 10000;
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential(
				"jeff.stuyvesant@cyberstudio.pro",
				"[real password]"
				);
//			smtpClient.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;

			MailMessage mailMsg = new MailMessage();
			mailMsg.From = new MailAddress("jeff.stuyvesant@cyberstudio.pro");
			mailMsg.To.Add("jeff.stuyvesant@cyberstudio.pro");

			mailMsg.Subject = "Revit HelpDesk Report";
			mailMsg.Body = body.ToString();

			smtpClient.Send(mailMsg);

		}


	}
}
