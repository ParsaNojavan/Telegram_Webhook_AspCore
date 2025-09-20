using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Webhook.Api.Models;
using Webhook.Api.Models.Interfaces;
using Webhook_Api.Models;

namespace Webhook_Api.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private TelegramBotClient _client;
        private IBot _bot;   
        public MessageController(IBot bot,
            IConfiguration configuration)
        {
            _configuration = configuration;
            BotSettings.BotToken = _configuration.GetValue<string>("BotSettings:BotToken");
            _bot = bot;
            _client = _bot.GetClient();
        }

        [HttpGet("configure")]
        public async Task<IActionResult> BotConfigure(string Url)
        {
            BotSettings.BotUrl = Url;

            await _bot.SetWebhook();
            
            return Ok("Webhook has been set");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if(update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                await _client.SendTextMessageAsync(update.Message.Chat.Id,"Message recieved");
            }

            return Ok();
        }
    }
}
