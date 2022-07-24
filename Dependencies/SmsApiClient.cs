using System.Threading.Tasks;

namespace Nml.Refactor.Me.Dependencies
{
	public class SmsApiClient
	{
		public SmsApiClient(string apiUrl, string apiToken)
		{
		}

		public Task SendAsync(string mobileNumber, string message)
		{
			return Task.CompletedTask;
		}
	}
}
