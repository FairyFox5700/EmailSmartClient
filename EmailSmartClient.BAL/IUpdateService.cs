using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace EmailSmartClient.BAL
{
    public interface IUpdateService
    {
        Task EchoAsync(Update update);
    }
}