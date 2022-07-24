using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Nml.Refactor.Me.Dependencies;
using Nml.Refactor.Me.MessageBuilders;

namespace Nml.Refactor.Me.Notifiers
{
	public class EmailNotifier : INotifier
	{
		private readonly IMailMessageBuilder _messageBuilder;
		private readonly IOptions _options;
		private readonly ILogger _logger = LogManager.For<EmailNotifier>();

		public EmailNotifier(IMailMessageBuilder messageBuilder, IOptions options)
		{
			_messageBuilder = messageBuilder ?? throw new ArgumentNullException(nameof(messageBuilder));
			_options = options ?? throw new ArgumentNullException(nameof(options));
		}
		
		public async Task Notify(NotificationMessage message)
		{
			var smtp = new SmtpClient(_options.Email.SmtpServer);
			smtp.Credentials = new NetworkCredential(_options.Email.UserName, _options.Email.Password);
			var mailMessage = _messageBuilder.CreateMessage(message);
			
			try
			{
				await smtp.SendMailAsync(mailMessage);
				_logger.LogTrace($"Message sent.");
			}
			catch (Exception e)
			{
				_logger.LogError(e, $"Failed to send message. {e.Message}");
				throw;
			}
		}
	}
}
