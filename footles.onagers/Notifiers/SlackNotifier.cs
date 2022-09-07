using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using footles.onagers.Notifiers;
using Nml.Refactor.Me.Dependencies;
using Nml.Refactor.Me.MessageBuilders;

namespace Nml.Refactor.Me.Notifiers
{
	public class SlackNotifier : Notifier
	{
        public SlackNotifier(IWebhookMessageBuilder messageBuilder, IOptions options) : base(messageBuilder, options)
        {
		}

        public async void Notifier(NotificationMessage message)
		{
			await Notify(message);

		}
	}
}
