using Tweetinvi;

var tweetTexts = new List<string>();
tweetTexts.Add("I just started a new project on GitHub. It will allow you to solve the sudoku puzzle. Check it out at: https://github.com/Dimon24021993/Sudoku-solver \n#csharpchallenge \n@IAmTimCorey");
tweetTexts.Add("I just started a new project on GitHub. It will allow you to calculate your mortgage payments with just a few basic values. Total mortgage cost, Monthly payment, as well as how a prepayment will affect your monthly payments.\nhttps://github.com/mikevankuik/MortgageCalculator\n#csharpchallenge @IAmTimCorey");


var userClient = new TwitterClient("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");
var keywords = new List<string>() { "#csharpchallenge", "@IAmTimCorey" };


var searchResponse = await userClient.SearchV2.SearchTweetsAsync(keywords[0]);
var tweets = searchResponse.Tweets.ToList();

Console.WriteLine("Welcome to challengers trackers!");
foreach (var tweet in tweets)
{
    Console.WriteLine($"{tweet.AuthorId} {tweet.CreatedAt.ToString("yyyy-MM-dd hh:mm")} : {tweet.Text}");
}
Console.ReadLine();