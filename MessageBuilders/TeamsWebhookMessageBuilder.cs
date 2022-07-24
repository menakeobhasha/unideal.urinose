using System;
using Newtonsoft.Json.Linq;
using Nml.Refactor.Me.Notifiers;

namespace Nml.Refactor.Me.MessageBuilders
{
	public class TeamsWebhookMessageBuilder : IWebhookMessageBuilder
	{
		public JObject CreateMessage(NotificationMessage message)
		{
			return new JObject(
				new JProperty("type", "MessageCard"),
				new JProperty("version", "1.0"),
				new JProperty(
					"sections",
					new JArray(
						new JObject(
							new JProperty("activityTitle", message.Subtitle),
							new JProperty("text", message.Body),
							new JProperty(
								"facts",
								new JArray(
									new JObject(
										new JProperty("name", "From"),
										new JProperty("value", message.From)),
									new JObject(
										new JProperty("name", "Date"),
										new JProperty("value", DateTime.Now))))))),
				new JProperty("Summary", message.Title),
				new JProperty("padding", "None"),
				new JProperty("@type", "AdaptiveCard"),
				new JProperty("@context", "http://schema.org/extensions"));
		}
	}

	/* TARGET MODEL
{
"type": "MessageCard",
"version": "1.0",
"sections": [
	{
		"activityTitle": "{{subtitle}}",
		"text": "{{message}}",
		"facts": [
			{
				"name": "From:",
				"value": "{{sender}}"
			},
			{
				"name": "Date:",
				"value": "{{date}}"
			}
		]
	}
],
"summary": "{{Title}}",
"padding": "None",
"@type": "AdaptiveCard",
"@context": "http://schema.org/extensions"
}
*/
}
