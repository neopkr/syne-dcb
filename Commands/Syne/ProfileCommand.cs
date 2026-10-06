using Discord;
using Discord.Interactions;

public class ProfileCommand : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("profile", "Todo: Add desc /Commands/Syne/ProfileCommand.cs")]
    public async Task CProfileAsync()
    {
        var profileEmbed = new EmbedBuilder() { Title = "SYNE // LYN COMMAND" }
            .AddField("Username", "Global #1")
            .AddField("PP", "9999.9", true)
            .AddField("Accuracy", "99.99%", true)
            .AddField("Plays", "999", true)
            .AddField("Play time", "99.9 h", true)
            .AddField("Grades", "99 SS · 999 S · 999 FC", true)
            .AddField("Recent", "A on MapName [diff]")
            .AddField("Profile", "https://web/profile")
            .WithImageUrl("https://media.discordapp.net/attachments/1535478352843120681/1550228375824502864/profile.png?ex=6abe0cee&is=6abcbb6e&hm=19cfb1a5938b3faddf8684c6ca5343da288532cddf538b7e16e80f6251cb1f1e&=&format=webp&quality=lossless")
            .Build();
            
        await RespondAsync(embed: profileEmbed);
    }
}