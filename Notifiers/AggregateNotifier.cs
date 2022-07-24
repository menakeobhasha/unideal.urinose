using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nml.Refactor.Me.Dependencies;

namespace Nml.Refactor.Me.Notifiers
{
	public class AggregateNotifier : INotifier
	{
		private readonly IDictionary<string, INotifier> _notifiers;
		private readonly IUserSettingsFinder _userSettingsFinder;

		public AggregateNotifier(IDictionary<string, INotifier> notifiers, IUserSettingsFinder userSettingsFinder)
		{
			_notifiers = notifiers ?? throw new ArgumentNullException(nameof(notifiers));
			_userSettingsFinder = userSettingsFinder ?? throw new ArgumentNullException(nameof(userSettingsFinder));
		}

		public async Task Notify(NotificationMessage message)
		{
			var communicationsChannels = CommunicationsChannelsForUser();

			var notifications = communicationsChannels
								.Select(NotifierForCommunicationsChannel)
								.Select(NotifyOnCommunicationChannel);

			await Task.WhenAll(notifications);
			
			//Local Functions
			IEnumerable<string> CommunicationsChannelsForUser() =>
				_userSettingsFinder.CommunicationsChannelsForUser(message.From);

			INotifier NotifierForCommunicationsChannel(string communicationsChannel) =>
				_notifiers[communicationsChannel];

			Task NotifyOnCommunicationChannel(INotifier notifier) => notifier.Notify(message);
		}
	}
}
