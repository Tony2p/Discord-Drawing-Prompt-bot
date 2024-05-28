using DiscordBotD.other;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotD.commands
{
    public class DrawingPromptCommands : BaseCommandModule
    {
        [Command("prompt")] //gives a basic drawing prompt
        public async Task Prompt(CommandContext ctx)
        {

            var drawingPrompt = new DrawingPrompt();

            var msg = await new DiscordMessageBuilder()

                .WithContent($"Here is your drawing prompt:{drawingPrompt.Theme} ")

                .SendAsync(ctx.Channel);
        }

        [Command("ref")] //shows websites for references
        public async Task Reference(CommandContext ctx)
        {

        }

    }
}
