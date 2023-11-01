using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            
            for (int i = 0; i <=  4; i++)
            {
                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var kanyeURL = "https://api.kanye.rest/";
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ron says:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ronQuote);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kanye says:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(kanyeQuote);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
