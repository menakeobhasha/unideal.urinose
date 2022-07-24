using System;
using Newtonsoft.Json.Linq;
using Nml.Refactor.Me.Notifiers;

namespace Nml.Refactor.Me.MessageBuilders
{
	public class SlackWebhookMessageBuilder : IWebhookMessageBuilder
	{
		public JObject CreateMessage(NotificationMessage message)
		{
			return new JObject(
				new JProperty("attachments",
							new JArray(
								new JObject(
									new JProperty("link_names", "1"),
									new JProperty("title", message.Subtitle),
									new JProperty("text",
												$"{message.Body}{Environment.NewLine}{Environment.NewLine}From {message.From}"),
									new JProperty("mrkdwn", true)))));
		}
	}
}
