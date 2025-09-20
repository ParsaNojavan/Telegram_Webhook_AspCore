using System.Runtime;
using Telegram.Bot;
using Webhook.Api.Models.Interfaces;
using Webhook_Api.Models;

namespace Webhook.Api.Models
{
    public class Bot : IBot
    {
        private readonly IConfiguration _configuration;
        private TelegramBotClient _client;
        private readonly ILogger _logger;
        public Bot(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public TelegramBotClient GetClient()
        {
            if (_client != null)
            {
                return _client;
            }
            _client = new TelegramBotClient(BotSettings.BotToken);
            return _client;
        }

        public async Task SetWebhook()
        {
            string webHookUrl = string.Format(BotSettings.BotUrl + "/{0}", "api/message");
            _client = new TelegramBotClient(BotSettings.BotToken);
            await _client.SetWebhookAsync(webHookUrl);
        }
    }
}
