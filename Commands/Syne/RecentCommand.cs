using Discord;
using Discord.Interactions;

// TODO: Add the connection with the database and change somehow the width space on the fields

public class RecentCommand : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("recent", "Show the most recent play")]
    public async Task CRecentAsync()
    {
        var embed = new EmbedBuilder()
            .WithTitle("USERNAME ~ GRADE")
            .WithDescription("SONG NAME [DIFFICULTY]")
            .WithColor(Color.Blue)
            .AddField("Score  ", "9,999,999  ", true)
            .AddField("Accuracy  ", "99.99%  ", true)
            .AddField("Combo  ", "9.999x  ", true)
            .AddField("Mods  ", "VRO.7  ", true)
            .AddField("Performance  ", "99.9pp  ", true)
            .AddField("Played  ", "9 minutes ago  ", true)
            .AddField("Score and replay", "https://web.com/scores/9999")
            .Build();

            await RespondAsync(embed: embed);
    }
}