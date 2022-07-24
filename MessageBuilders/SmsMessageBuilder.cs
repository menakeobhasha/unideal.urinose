using Nml.Refactor.Me.Notifiers;

namespace Nml.Refactor.Me.MessageBuilders
{
	public class SmsMessageBuilder : IStringMessageBuilder
	{
		public string CreateMessage(NotificationMessage message)
		{
			return message.Body;
		}
	}
}
