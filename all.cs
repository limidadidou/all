using System;
using System.Net;
public class WEB
{
    static void Main()
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
        Console.Write("URL: ");
        string url=Console.ReadLine();
        Console.Write("RESULT: ");
        string result = Console.ReadLine();
        using (WebClient tyty = new WebClient())
        {
            tyty.DownloadFile(new Uri(url), result);
        }
    }
}