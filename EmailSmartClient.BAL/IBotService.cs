using Telegram.Bot;

namespace EmailSmartClient.BAL
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}