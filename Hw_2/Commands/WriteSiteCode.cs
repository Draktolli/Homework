using System.Net;
using System.Text;

namespace Hw_2.Commands;

public class WriteSiteCode
{
    public void GetSiteCode (string url)
    {
        string data = "";
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        Cookie cookie = new Cookie
        {
            Name = "beget",
            Value = "begetok"
        };
        req.CookieContainer = new CookieContainer();
		req.CookieContainer.Add(new Uri(url), cookie);
        HttpWebResponse response = (HttpWebResponse)req.GetResponse();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = null;
            if (response.CharacterSet == null)
            {
                readStream = new StreamReader(receiveStream);
            }
            else
            {
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            }
            data = readStream.ReadToEnd();
            response.Close();
            readStream.Close();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(response.StatusCode);
            Console.ForegroundColor = ConsoleColor.White;
        }
        File.AppendAllText("../../../TextFiles/TextFile2.txt", data);
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("успешно");
		Console.ForegroundColor = ConsoleColor.White;
	}
}