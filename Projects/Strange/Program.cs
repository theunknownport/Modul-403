using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strange
{
    class Program
    {
        static void Main(string[] args)
        {

            int weiter = 1;
            while (true)
            {
                
                Console.WriteLine("Gib deine ziel IP ein");
                string serverip =(Console.ReadLine());
                UdpClient client = new UdpClient(); ;
                while (weiter == 1)
                {
                    Console.WriteLine("Gib deine Nachricht ein:");
                    string message = Console.ReadLine();
                    String toServer = message;
                    client.Send(Encoding.ASCII.GetBytes(toServer), toServer.Length, serverip, 1234);
                    Console.WriteLine("Willst du weiter senden? (j für Ja)");
                    string choice = Console.ReadLine();
                    if (choice == "j")
                    {
                        weiter = 1;
                    }
                    else
                    {
                        weiter = 0;
                    }
                   
                }
               
                client.Close();
                break;
            }
            

        }
    }
}
