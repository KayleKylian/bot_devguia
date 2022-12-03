using Telegram.Bot;

var botClient = new TelegramBotClient("{$BOTTOKEN}");

var me = await botClient.GetMeAsync();
Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}");