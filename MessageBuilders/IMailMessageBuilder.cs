using System.Net.Mail;

namespace Nml.Refactor.Me.MessageBuilders
{
	public interface IMailMessageBuilder : IMessageBuilder<MailMessage>
	{
	}
}
