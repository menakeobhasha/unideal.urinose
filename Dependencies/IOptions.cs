namespace Nml.Refactor.Me.Dependencies
{
	public interface IOptions
	{
		public ITeamsOptions Teams { get; set; }
		public ISlackOptions Slack { get; set; }
		public IEmailOptions Email { get; set; }
		public ISmsOptions Sms { get; set; }

		public interface ITeamsOptions
		{
			string WebhookUri { get; set; }
		}
	
		public interface ISlackOptions 
		{
			string WebhookUri { get; set; }
		}
		
		public interface IEmailOptions
		{
			public string SmtpServer { get; set; }
			public string UserName { get; set; }
			public string Password { get; set; }
		}

		public interface ISmsOptions
		{
			public string ApiUri { get; set; }
			public string ApiKey { get; set; }
			
		}
	}
}
