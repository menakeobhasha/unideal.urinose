using Nml.Refactor.Me.Notifiers;

namespace Nml.Refactor.Me.MessageBuilders
{
	public interface IMessageBuilder<out TMessageType>
	{
		TMessageType CreateMessage(NotificationMessage message);
	}
}
