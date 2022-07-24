using System.Net.Mail;
using Nml.Refactor.Me.Notifiers;

namespace Nml.Refactor.Me.MessageBuilders
{
	public class MailMessageBuilder : IMailMessageBuilder
	{
		public MailMessage CreateMessage(NotificationMessage message)
		{
			return new MailMessage
			{
				From = new MailAddress(message.From),
				Body = message.Body,
				Subject = $"{message.Title} - {message.Subtitle}",
				To = { new MailAddress(message.To) }
			};
		}
	}
}
