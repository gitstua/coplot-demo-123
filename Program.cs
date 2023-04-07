//add using for webclient
using System.Net;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// obtain public ip address into variable
//string publicIpAddress = new WebClient().DownloadString("https://api.ipify.org");

// obtain public ip address into variable using httpclient
string publicIpAddress = new HttpClient().GetStringAsync("https://api.ipify.org").Result;

// print public ip address
Console.WriteLine(publicIpAddress);

//get the current date and time
DateTime now = DateTime.Now;

//print the current date and time in utc format
Console.WriteLine(now.ToUniversalTime());

//get the current temperaturein london using httpclient from bbc weather
string temperature = new HttpClient().GetStringAsync("https://weather-broker-cdn.api.bbci.co.uk/en/observation/rss/2643743").Result;

//print the current temperature in london
Console.WriteLine(temperature.Substring(temperature.IndexOf("Temperature: ")+13, 2));

//make a list of zoo animals
List<string> zooAnimals = new List<string>();

//add animals to the list
zooAnimals.Add("Lion");
zooAnimals.Add("Tiger");
zooAnimals.Add("Bear");
zooAnimals.Add("Elephant");
zooAnimals.Add("Giraffe");
zooAnimals.Add("Monkey");
zooAnimals.Add("Hippo");
zooAnimals.Add("Lemur");
zooAnimals.Add("Gorilla");
zooAnimals.Add("Zebra");
zooAnimals.Add("Horse");
zooAnimals.Add("Crocodile");
zooAnimals.Add("Rhino");
zooAnimals.Add("Penguin");
zooAnimals.Add("Flamingo");
zooAnimals.Add("Kangaroo");
zooAnimals.Add("Panda");
zooAnimals.Add("Ostrich");
zooAnimals.Add("Rabbit");
zooAnimals.Add("Pig");
zooAnimals.Add("Sheep");
zooAnimals.Add("Dog");
zooAnimals.Add("Cat");

//print 2 random animals from the list
Console.WriteLine(zooAnimals[new Random().Next(0, zooAnimals.Count)]);
Console.WriteLine(zooAnimals[new Random().Next(0, zooAnimals.Count)]);

//get a list of the azure ip addresses for azure devops in json format
string azureIpAddresses = new HttpClient().GetStringAsync("https://www.microsoft.com/en-us/download/confirmation.aspx?id=56519").Result;

//get a list of australin states short codes capitalised
List<string> australianStates = new List<string>();
australianStates.Add("ACT");
australianStates.Add("NSW");
australianStates.Add("NT");
australianStates.Add("QLD");
australianStates.Add("SA");
australianStates.Add("TAS");
australianStates.Add("VIC");
australianStates.Add("WA");

//print a random australian state
Console.WriteLine(australianStates[new Random().Next(0, australianStates.Count)]);

string creditcardNumber = "1234567890123456";

//print type of credit card based on number
if (creditcardNumber.StartsWith("4"))
{
    Console.WriteLine("Visa");
}
else if (creditcardNumber.StartsWith("5"))
{
    Console.WriteLine("Mastercard");
}
else if (creditcardNumber.StartsWith("6"))
{
    Console.WriteLine("Discover");
}
else if (creditcardNumber.StartsWith("3"))
{
    Console.WriteLine("American Express");
}
else
{
    Console.WriteLine("Unknown");
}

var email = "a@b.com";
//validate email address
