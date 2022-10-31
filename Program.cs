using System;
using System.Linq;
using System.Windows;
using System.Net;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Threading;

namespace HitlerSpammer
{
	public class Program
	{
		public static void send(string URL, string profilepic, string username, string message)
        {
                NameValueCollection discordValues = new NameValueCollection();
                discordValues.Add("username", username);
                discordValues.Add("avatar_url", profilepic);
                discordValues.Add("content", message);
                new WebClient().UploadValues(URL, discordValues);
        }
        static string WebHook = "";
        string Username = "HITLER IS THE BEST";
        int sended = 0;
        string Avatar = "https://upload.wikimedia.org/wikipedia/commons/2/2b/N%C3%BCrnberg_Reichsparteitag_Hitler_retouched_%28teapot-cropped%29.jpg";
		
        string text = "🟥🟥🟥🟥🟥🟥⬜⬜⬜⬜⬜⬜⬜⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n🟥🟥🟥🟥🟥🟥⬜⬜⬛⬜⬛⬛⬛⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n🟥🟥🟥🟥🟥🟥⬜⬜⬛⬜⬛⬜⬜⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n🟥🟥🟥🟥🟥🟥⬜⬜⬛⬛⬛⬛⬛⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n🟥🟥🟥🟥🟥🟥⬜⬜⬜⬜⬛⬜⬛⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n🟥🟥🟥🟥🟥🟥⬜⬜⬛⬛⬛⬜⬛⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n🟥🟥🟥🟥🟥🟥⬜⬜⬜⬜⬜⬜⬜⬜⬜🟥🟥🟥🟥🟥🟥"
		+ "\n@everyone @here"
		+ "\n"
		+ "\n"
		+ "\n";
		public void Main()
		{
			



		

		
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.WriteLine(@"
██╗░░██╗██╗████████╗██╗░░░░░███████╗██████╗░
██║░░██║██║╚══██╔══╝██║░░░░░██╔════╝██╔══██╗
███████║██║░░░██║░░░██║░░░░░█████╗░░██████╔╝
██╔══██║██║░░░██║░░░██║░░░░░██╔══╝░░██╔══██╗
██║░░██║██║░░░██║░░░███████╗███████╗██║░░██║
╚═╝░░╚═╝╚═╝░░░╚═╝░░░╚══════╝╚══════╝╚═╝░░╚═╝

░██████╗██████╗░░█████╗░███╗░░░███╗
██╔════╝██╔══██╗██╔══██╗████╗░████║
╚█████╗░██████╔╝███████║██╔████╔██║
░╚═══██╗██╔═══╝░██╔══██║██║╚██╔╝██║
██████╔╝██║░░░░░██║░░██║██║░╚═╝░██║
╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝");
        Console.ResetColor();
		Console.WriteLine("\n\n");
		Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter Webhook");
        Console.ResetColor();
        WebHook = Console.ReadLine();
        Spammer();
		}
		public void Spammer()
		{
        if (WebHook.StartsWith("https://discord.com/api/webhooks"))
        {
        	while(true)
        	try
        	{
        	
        		sended++;
        		Console.ForegroundColor = ConsoleColor.Cyan;
        		Console.WriteLine("Sended - " + sended);
        		Console.ResetColor();
        		send(WebHook, Avatar, Username, text);
        		
        	
        	}
        	catch
        	{
        		Spammer();
        	}
        }
        else 
        {
        	Console.WriteLine("Error");
        	Thread.Sleep(1000);
        	Main();
        }

		}
	}
	
	
}