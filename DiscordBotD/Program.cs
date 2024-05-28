using DiscordBotD.commands;
using DiscordBotD.config;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Threading.Tasks;

namespace DiscordBotD
{
    internal class Program
    {
        public static DiscordClient Client { get; set; }
        public static CommandsNextExtension Commands { get; set; } 
        static async Task Main(string[] args)
        {
            var jsonReader = new JSONReader();
            await jsonReader.ReadJson();


            //setting up the bot config
            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
            };


            //applying config to the client
            Client = new DiscordClient(discordConfig);

            //setting up the default timeout for commands that use interactivity
            Client.UseInteractivity(new InteractivityConfiguration()
            {
                Timeout = TimeSpan.FromMinutes(2)
            });

            //setting up the task handler ready event
            Client.Ready += Client_Ready;
            Client.MessageCreated += MessageCreatedHandler;

            //setting up the commands config
            var commandsConfig = new CommandsNextConfiguration()
            {
               StringPrefixes = new string[] { jsonReader.prefix },
               EnableMentionPrefix = true,
               EnableDms = true,
               EnableDefaultHelp = false,
            };

            Commands = Client.UseCommandsNext(commandsConfig);


            //registering the commands
            Commands.RegisterCommands<BasicCommands>();
            Commands.RegisterCommands<DrawingPromptCommands>();



            //connecting to get the bot online
            await Client.ConnectAsync();
            await Task.Delay(-1); //-1 means infinite, it will run until I stop it.

        }

        //event handler methods
        private static async Task MessageCreatedHandler(DiscordClient sender, MessageCreateEventArgs e)
        {
            if(e.Message.Content.ToLower() == "croissant")
                await e.Channel.SendMessageAsync("quaso");

            if(e.Message.Content.ToLower() == "proko")
                await e.Channel.SendMessageAsync("Proko is a great artist, you should check him out on youtube");
        }
        private static Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
        {
            return Task.CompletedTask;
        }
    }
}
