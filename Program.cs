using Discord.WebSocket;
using Discord;
using Discord.Interactions;

class Program
{
    private DiscordSocketClient _client = null!;
    private InteractionService _interaction = null!;

    static async Task Main()
    {
        var program = new Program();
        await new Database().CheckAlive();
        //await program.RunBotAsync();
    }

    private async Task RunBotAsync()
    {
        _client = new DiscordSocketClient();
        _interaction = new InteractionService(_client.Rest);

        _client.Log += LogAsync;
        _client.Ready += ReadyAsync;
        _client.InteractionCreated += HandleInteractionAsync;

        string token = "MTU1MzU2NzA1MzExNjM1MDU4NQ.G36vaZ.5J_vah0H9247y-U34MuYJ9cR82aIQiouDIZzmU";

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private async Task HandleInteractionAsync(SocketInteraction interaction)
    {
        var context = new SocketInteractionContext(_client, interaction);
        await _interaction.ExecuteCommandAsync(context, null);
    }

    private Task LogAsync(LogMessage message)
    {
        System.Console.WriteLine(message);
        return Task.CompletedTask;
    }

    private async Task ReadyAsync()
    {
        System.Console.WriteLine($"Bot conectado como {_client.CurrentUser}");
        
        await _interaction.AddModulesAsync(typeof(Program).Assembly, null);

        foreach (var guild in _client.Guilds)
        {
            await _interaction.RegisterCommandsToGuildAsync(guild.Id);
        }

        System.Console.WriteLine("Commands Registered.");
    }
}