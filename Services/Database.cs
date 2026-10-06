public class Database
{
    public readonly string BASE_URL = "https://api.zxz.moe";
    private readonly string API_KEY = "lyne_pat_K4hKtewp30SGiY-Jc33OzxMbvyaigI4FNa1m3bPMCl0";
    private readonly HttpClient WebClient = new HttpClient();

    public async Task<Boolean> CheckAlive()
    {
        try
        {
            string response = await WebClient.GetStringAsync($"{BASE_URL}/me");
            //System.Console.WriteLine(response);
            System.Console.WriteLine("Debug: API Server alive.");
            return true;
        } catch (HttpRequestException e)
        {
            if (e.StatusCode != System.Net.HttpStatusCode.NotFound || e.StatusCode != System.Net.HttpStatusCode.InternalServerError)
            {
                System.Console.WriteLine("Debug: API Server alive.");
                return true;
            }
            System.Console.WriteLine($"Error en la peticion CheckAlive: {e}");
            return false;
        }
    }

}