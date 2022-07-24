using System.Collections.Generic;

namespace Nml.Refactor.Me.Dependencies
{
	public interface IUserSettingsFinder
	{
		IEnumerable<string> CommunicationsChannelsForUser(string messageFrom);
	}
}
