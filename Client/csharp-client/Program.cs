using System;
using WebSocketSharp;


namespace csharp_client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebSocket ws = new WebSocket("ws://192.168.0.111:81/"))
            {
                ws.OnMessage += Ws_OnMessage;

                ws.Connect();
                ws.Send("Hello arduino");

                Console.ReadKey();
            }
        }

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Received from the server: " + e.Data);
        }
    }
}
