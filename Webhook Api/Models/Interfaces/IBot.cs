using Telegram.Bot;

namespace Webhook.Api.Models.Interfaces
{
    public interface IBot
    {
        TelegramBotClient GetClient();
        Task SetWebhook();
    }
}
