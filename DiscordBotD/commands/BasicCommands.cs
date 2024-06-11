using DiscordBotD.other;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Threading.Tasks;

namespace DiscordBotD.commands
{
    public class BasicCommands : BaseCommandModule
    {
        [Command("help")]
        public async Task Help(CommandContext ctx)
        {
            var message = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()
                    .WithColor(DiscordColor.HotPink)
                    .WithTitle("Command List")
                    .WithDescription("**!pfp + @Username** - Get the profile picture of a server member ----- (NSFW warning if used on Aster) \n" +
                                     "**!prompt** - Don't know what to draw? Me neither \n" +
                                     "**!ref** - Get resource suggestions by yours truly \n"));

            await ctx.Channel.SendMessageAsync(message);                                                                                                                                                                                    
        }

        [Command("pfp")]
        
        public async Task ProfilePicture(CommandContext ctx, DiscordMember member) //Gets the profile picture of a chosen server member

        {
            await ctx.Channel.SendMessageAsync(member.AvatarUrl);
        }

               
        //--------------------------------------------------------------------------------------------------------------



        [Command("cardgame")]
        public async Task CardGame(CommandContext ctx)
        {
            var userCard = new CardSystem();

            var userCardEmbed = new DiscordEmbedBuilder
            {
                Title = $"Your card is {userCard.SelectedCard}",
                Color = DiscordColor.Blue,
            };

            await ctx.Channel.SendMessageAsync(embed: userCardEmbed);

            var botCard = new CardSystem();

            var botCardEmbed = new DiscordEmbedBuilder
            {
                Title = $"Dave's card is {botCard.SelectedCard}",
                Color = DiscordColor.Red,

            };

            await ctx.Channel.SendMessageAsync(embed: botCardEmbed);

            if (userCard.SelectedNumber > botCard.SelectedNumber)
            {
                //User wins
                var messageWin = new DiscordEmbedBuilder
                {
                    Title = "You card is higher, but Dave won anyway!",
                    Color = DiscordColor.Green,
                };

                await ctx.Channel.SendMessageAsync(embed: messageWin);
            }else
            {
                //Dave wins
                var messageLose = new DiscordEmbedBuilder
                {
                    Title = "Dave's card is higher, you lose!",
                    Color = DiscordColor.Red,
                };

                await ctx.Channel.SendMessageAsync(embed: messageLose);
            }
            
            
        }

        
    }
}
