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

            var message = await new DiscordMessageBuilder()

                .WithContent($"I dare you to draw me something following this prompt: \n" +
                $"\n" +
                $"**Theme:** {drawingPrompt.Theme} \n" +
                $"**Subject:** {drawingPrompt.Subject} \n" +
                $"**Cultural Inspiration:** {drawingPrompt.Culture} \n" +
                $"**Dominant Color:** {drawingPrompt.ColorScheme} \n " +
                $"\n" +
                $"in {drawingPrompt.TimeLimit} minutes")

                .SendAsync(ctx.Channel);
        }

    }
}
