using System.Threading.Tasks;

namespace Nml.Refactor.Me.Notifiers
{
	public interface INotifier
	{
		Task Notify(NotificationMessage message);
	}
}
