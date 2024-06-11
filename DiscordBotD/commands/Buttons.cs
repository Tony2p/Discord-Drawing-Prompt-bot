using DSharpPlus;
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
    public class Buttons : BaseCommandModule
    {
        [Command("Ref")]
        public async Task RefButton(CommandContext ctx)
        {
            var figureButton = new DiscordButtonComponent(ButtonStyle.Success, "figureButton", "Figure Drawing");
            var anatomyButton = new DiscordButtonComponent(ButtonStyle.Primary, "anatomyButton", "Anatomy");
            var colorButton = new DiscordButtonComponent(ButtonStyle.Danger, "colorButton", "Color Theory");
            var designButton = new DiscordButtonComponent(ButtonStyle.Secondary, "designButton", "Design");

            var message = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()
                   .WithColor(DiscordColor.Gold)
                   .WithTitle("What do you need now?"))
                .AddComponents(figureButton, anatomyButton, colorButton, designButton); //Can max have 5 buttons


            await ctx.Channel.SendMessageAsync(message);
        }
    }
}
