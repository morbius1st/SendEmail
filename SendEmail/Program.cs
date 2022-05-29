using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

using System.Text;
using SendEmail.MailProtocol;

namespace SendEmail
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			SendMailByMyProcess();

			Console.WriteLine("Mail sent");
			Console.WriteLine("Press key... ");

			Console.ReadKey();
		}

		private static void TestInfo()
		{
			try
			{
				StringBuilder sb = new StringBuilder();

				sb.Append("User Name | ").AppendLine(System.Environment.UserName);
				sb.Append("User Domain Name | ").AppendLine(System.Environment.UserDomainName);
				sb.Append("Current Directory | ").AppendLine(System.Environment.CurrentDirectory);

			}
			catch 
			{
				Console.WriteLine("exception: using"+ System.Environment.UserName);
				throw;
			}
		}

		private static void TestMail()
		{
			MailAddress to = new MailAddress("jeff.stuyvesant@cyberstudio.pro");
	


			var smtp = new SmtpClient();
//			smtp.Host = "localhost"; //your mail server host name or ip address
			var host = to.Host;
			var port = smtp.Port;
			Console.WriteLine("{0}:{1}", host, port);
		}


		private static void SendMailByMyProcess()
		{
			// attachment does not work
//			string mailto =
//				@"mailto:jeff.stuyvesant@cyberstudio.pro?subject=subject of message&Body=This is a body of a message"
//				+ "&Attachment=D:\\Users\\Jeff\\Documents\\Programming\\VisualStudioProjects\\SendEmail\\SendEmail\\TextFile.txt";

// this will not work as, i guess, the path is too long
			string body; // =
//				"User Name\t|\tjeffs@architectsorange.com\r\nUser Id\t|\tTVFGJX5H67P7\r\nAll Users Addins Location\t|\tC:\\ProgramData\\Autodesk\\Revit\\Addins\\2018\r\nCurrent User Addins Location\t|\tC:\\Users\\jeffs\\AppData\\Roaming\\Autodesk\\Revit\\Addins\\2018\r\nShared Parameters Filename\t|\tD:\\Users\\Jeff\\OneDrive\\Office\\Drawings & Revit\\Revit Projects\\Revit Configuration\\Share Parameters-1.txt\r\nSub Version Number\t|\t2018.0\r\nVersion Build\t|\t20170223_1515(x64)\r\nRecording Journal Filename\t|\tC:\\Users\\jeffs\\AppData\\Local\\Autodesk\\Revit\\Autodesk Revit 2018\\Journals\\journal.0346.txt\r\nVersion Name\t|\tAutodesk Revit 2018\r\nVersion Number\t|\t2018\r\nActive AddIn Name\t|\tApplication HelpDesk\r\nLanguage\t|\tEnglish_USA\r\nProduct\t|\tRevit\r\nDocument Path Name\t|\tD:\\Users\\Jeff\\OneDrive\\Office\\Drawings & Revit\\Revit Projects\\Revit Configuration\\ConfigTest.rvt\r\nDocument Title\t|\tConfigTest.rvt\r\nActive View\t|\tSheet: CS.0-0 - COVER SHEET(COVER SHEET)\r\nDocument Set\t|\tName\r\nDocument Set Item 0\t|\tAutodesk.Revit.DB.Document (Autodesk.Revit.DB.Document)\r\nLibrary Paths\t|\tPath\r\nLibrary Path 0\t|\tC:\\ProgramData\\Autodesk\\RVT 2018\\Libraries\\US Imperial\\Detail Items\r\nLibrary Path 1\t|\tC:\\ProgramData\\Autodesk\\RVT 2018\\Libraries\\US Imperial\\\r\nServer Network Hosts\t|\tHost Name\r\nLoaded Applications 0\t|\tAutodesk.RaaS.RevitAddin.EApplication (Autodesk.RaaS.RevitAddin.EApplication)\r\nLoaded Applications 1\t|\tAutoLoader.AutoLoader (AutoLoader.AutoLoader)\r\nLoaded Applications 2\t|\tConnectedDesktopUI.ServerApp (ConnectedDesktopUI.ServerApp)\r\nLoaded Applications 3\t|\tAutodesk.CoordinationModelUI.CoordinationModelUIApplication (Autodesk.CoordinationModelUI.CoordinationModelUIApplication)\r\nLoaded Applications 4\t|\tEnergyAnalysis.Application (EnergyAnalysis.Application)\r\nLoaded Applications 5\t|\tFabricationPartBrowser.FabPartBrowserApplication (FabricationPartBrowser.FabPartBrowserApplication)\r\nLoaded Applications 6\t|\tFittingAndAccessoryCalculationUIServers.ServerApp (FittingAndAccessoryCalculationUIServers.ServerApp)\r\nLoaded Applications 7\t|\tBIM.IFC.Export.UI.IFCCommandOverrideApplication (BIM.IFC.Export.UI.IFCCommandOverrideApplication)\r\nLoaded Applications 8\t|\tKeynoteUIServer.ServerApp (KeynoteUIServer.ServerApp)\r\nLoaded Applications 9\t|\tMemberForcesUI.ServerApp (MemberForcesUI.ServerApp)\r\nLoaded Applications 10\t|\tBIM.Numbering.UI.NumberingUIApplication (BIM.Numbering.UI.NumberingUIApplication)\r\nLoaded Applications 11\t|\tPointCloudSnappingServer.Application (PointCloudSnappingServer.Application)\r\nLoaded Applications 12\t|\tPressureLossReport.PressureLossReportApplication (PressureLossReport.PressureLossReportApplication)\r\nLoaded Applications 13\t|\tRebarMorphedServer.RebarUpdateApp (RebarMorphedServer.RebarUpdateApp)\r\nLoaded Applications 14\t|\tSectionProperties.ServerApp (SectionProperties.ServerApp)\r\nLoaded Applications 15\t|\tSiteLinker.SiteExportApp (SiteLinker.SiteExportApp)\r\nLoaded Applications 16\t|\tSpaceNaming.Command (SpaceNaming.Command)\r\nLoaded Applications 17\t|\tRvtParameterOrganizer.ExtApp (RvtParameterOrganizer.ExtApp)\r\nLoaded Applications 18\t|\tDluxMeasure.AppRibbon (DluxMeasure.AppRibbon)\r\nLoaded Applications 19\t|\tRevit.PrintHarness.PrintHarnessApplication (Revit.PrintHarness.PrintHarnessApplication)\r\nLoaded Applications 20\t|\tAutodesk.Revit.UI.Collaborate.CollaborateApplication (Autodesk.Revit.UI.Collaborate.CollaborateApplication)\r\nLoaded Applications 21\t|\tAutodesk.Revit.UI.CollaborateBrowser.CollaborateBrowserApplication (Autodesk.Revit.UI.CollaborateBrowser.CollaborateBrowserApplication)\r\nLoaded Applications 22\t|\tSkyscraperClientHost.SkyscraperClientHostApplication (SkyscraperClientHost.SkyscraperClientHostApplication)\r\nLoaded Applications 23\t|\teTransmitForRevit.eTransmitApplication (eTransmitForRevit.eTransmitApplication)\r\nLoaded Applications 24\t|\tBIMStandardsManager.ExternalApp (BIMStandardsManager.ExternalApp)\r\nLoaded Applications 25\t|\tWorkSharingLib.ExternalApplication (WorkSharingLib.ExternalApplication)\r\nLoaded Applications 26\t|\tWorksharingCommand.WorksharingApp (WorksharingCommand.WorksharingApp)\r\nLoaded Applications 27\t|\tAutodesk.Revit.SmartMonkeyPlugin.SmartMonkeyApplication (Autodesk.Revit.SmartMonkeyPlugin.SmartMonkeyApplication)\r\nLoaded Applications 28\t|\tSharedCreate.ApplicationRibbon (SharedCreate.ApplicationRibbon)\r\nLoaded Applications 29\t|\tCTC.RET.SuiteExternalApp.App (CTC.RET.SuiteExternalApp.App)\r\nLoaded Applications 30\t|\tCTC.RET.SuiteExternalApp.App (CTC.RET.SuiteExternalApp.App)\r\nLoaded Applications 31\t|\tSharedCode.ApplicationRibbon (SharedCode.ApplicationRibbon)\r\nLoaded Applications 32\t|\tDynamo.Applications.VersionLoader (Dynamo.Applications.VersionLoader)\r\nLoaded Applications 33\t|\tAutodesk.Revit.Addin.ExportViewSelector.ExportViewSelectorApp (Autodesk.Revit.Addin.ExportViewSelector.ExportViewSelectorApp)\r\nLoaded Applications 34\t|\tFormItConverter.Ribbon (FormItConverter.Ribbon)\r\nLoaded Applications 35\t|\tHelpDesk.RibbonApp (HelpDesk.RibbonApp)\r\n";


// works!!!
			body =
				"DIAGNOSTIC INFO\r\n===============\r\nUSER: Cecilia & Cardenas\r\nEMAIL: ccardenas@aoarchitects.com\r\nCOMPUTER: OK-3025\r\nREVIT VERSION: Autodesk Revit 2018 | 20190510_1515(x64)\r\nTOTAL MEMORY: 32 GB\r\nFREE MEMORY: 23.6 GB\r\n\r\nLOCAL MODEL: C:\\KTGY-Revit2018Projects\\170394_Alameda Point_Block 6_ccardenas.rvt\r\nCENTRAL MODEL: \\\\corp.ktgy.com\\global\\Oakland\\Projects\\2017\\170394 Alameda Point TH Block 6\\Construction Drawings\\Revit\\170394_Alameda Point_Block 6.rvt\r\nMODEL FILE SIZE: 322.8 MB\r\nREVIT SERVER ACCELERATOR: OAKREVIT1\r\n";

			string data = Uri.EscapeDataString(body);
			body = Uri.EscapeUriString(body).Replace("&", "%26");


// this works when the body is shorter
			string mailto =
				@"mailto:jeff.stuyvesant@cyberstudio.pro?subject=subject of message&Body=";

			mailto = Uri.EscapeUriString(mailto) + body;

			Process myprocess = new Process();

			myprocess.StartInfo.FileName = mailto;
			myprocess.StartInfo.UseShellExecute = true;
			myprocess.StartInfo.RedirectStandardOutput = false;

			Console.WriteLine("as data:");
			Console.WriteLine(data);


			Console.WriteLine("\n\nas uri:");
			Console.WriteLine(mailto);

			myprocess.Start();

		}



		// other tests

		private static void SendMailBySystemNetMail()
		{
			// does not work
			string file =
				"D:\\Users\\Jeff\\Documents\\Programming\\VisualStudioProjects\\SendEmail\\SendEmail\\TextFile.txt";
			// Create a message and set up the recipients.
			MailMessage message = new MailMessage(
				"jeff.stuyvesant@cyberstudio.pro",
				"jeff.stuyvesant@cyberstudio.pro",
				"Quarterly data report.",
				"See the attached spreadsheet.");

			// Create  the file attachment for this e-mail message.
			Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
			// Add time stamp information for the file.
			ContentDisposition disposition = data.ContentDisposition;
			disposition.CreationDate = System.IO.File.GetCreationTime(file);
			disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
			disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
			// Add the file attachment to this e-mail message.
			message.Attachments.Add(data);

			//Send the message.
			SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
			// Add credentials if the SMTP server requires them.
			client.Credentials = CredentialCache.DefaultNetworkCredentials;

			try
			{
				client.Send(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception caught in CreateMessageWithAttachment(): {0}",
					ex.ToString() );
			}

			data.Dispose();
		}


		
		private static void SendMailByMyProcess2()
		{
			string mailto =
				"<form action=\"mailto:user@example.com\" method=\"get\">\r\n<input name=\"subject\" type=\"hidden\" value=\"Message Title\">\r\n\r\nFeedback:<br/>\r\n<textarea name=body cols=\"40\">\r\nPlease share your thoughts here\r\nand then choose Send Feedback.\r\n</textarea>\r\n\r\n<input type=\"submit\" value=\"Send Feedback\">\r\n</form>";

//			mailto = Uri.EscapeUriString(mailto);

			Process myprocess = new Process();

			myprocess.StartInfo.FileName = mailto;
			myprocess.StartInfo.UseShellExecute = true;
			myprocess.StartInfo.RedirectStandardOutput = false;

			Console.WriteLine(mailto);

			myprocess.Start();

		}


		private static void SendMailByProcessStart()
		{
			string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}",
				@"jeff.stuyvesant@cyberstudio.pro",
				"Subject of message",
				"This is a body of a message");

			mailto = string.Format("mailto:{0}",
				@"jeff@cyberstudioapps.com");

			mailto = Uri.EscapeUriString(mailto);
			System.Diagnostics.Process.Start(mailto);
		}


		// does not work
		private static void SendMailViaMAPI()
		{
			MAPI mapi = new MAPI();

			mapi.AddAttachment(@"B:\Programming\VisualStudioProjects\SendEmail\SendEmail\TextFile.txt");
			mapi.AddRecipientTo("jeff.stuyvesant@cyberstudio.pro");

			mapi.SendMailPopup("testing", "body text");
		}
	}
}