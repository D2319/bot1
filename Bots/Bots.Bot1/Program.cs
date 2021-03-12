using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Bots.Bot1
{
    class Program
    {
        private static ITelegramBotClient _botClient;

        static void Main(string[] args)
        {
            _botClient = new TelegramBotClient("1660343520:AAFhEnslDFZgjUHoOSAcl4sIkFL7UCvg68Q");
            _botClient.OnMessage += OnMessage;
            _botClient.StartReceiving();
            Console.ReadKey();
            _botClient.StopReceiving();
        }
        private static async void OnMessage(object sender, MessageEventArgs args) 
        {
            // if (args.Message.Text != null && args.Message.Text != "")
            if (!string.IsNullOrWhiteSpace(args.Message.Text))
            {
                Console.WriteLine($"мне прислали сообщение из чата{args.Message.Chat.Id}");
            }
            await _botClient.SendTextMessageAsync(args.Message.Chat.Id, "hi");
        } 
    }
}
