using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server8Ball
{
    class SynchronousSocketListener
    {
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        //new instance of brains class
        Brains brains;
        //instance of tcp listener from .net.sockets
        TcpListener listener;
        //response text variable
        string responseText = "";
        /// <summary>
        /// ctor method that creates an instance of brains and loads the file.
        /// </summary>
        public SynchronousSocketListener()
        {
            // brains ctor call 
            brains = new Brains();
            // call load file method in brains class
            brains.LoadFile();
        }

        /// <summary>
        /// method to start listener
        /// </summary>
        public void Startlistening()
        {
            //
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            //
            listener = new TcpListener(iPAddress, PORT);
            //
            listener.Start();
            //
            Thread thread = new Thread(new ThreadStart(ProcessSocket));
            //start thread
            thread.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ProcessSocket()
        {
            //new instance of socket
            Socket socket = null;
            while (true)
            {
                //try catch block for creating socket listener
                try
                {
                    //defines the socket that we are listening on
                    socket = listener.AcceptSocket();
                    //network stream instance to read and write to network
                    NetworkStream stream = new NetworkStream(socket);
                    //reading and writing from the network using system.io
                    StreamReader sr = new StreamReader(stream);
                    StreamWriter sw = new StreamWriter(stream);

                    //auto flush to get rid of any unneccissary text that was left in the file
                    sw.AutoFlush = true;

                    //capture user input
                    string userinput = sr.ReadLine();
                    //write user input into the console
                    Console.WriteLine("Recieved from client: " + userinput);

                    //if else for response text loading 
                    if (userinput == "")
                    {
                        // response if there is no text and it is coming from a console
                        responseText = "Hello World";
                    }
                    else if (userinput == "GET")
                    {
                        //response if the user is a web browser
                        responseText = "Hello Browser!";
                    }
                    else
                    {
                        // fill variable response text with random response from brain class
                        responseText = brains.GetRandomEightballResp();
                    }
                    //response displayed to client
                    Console.WriteLine($"sending back to client: {responseText}");
                    //reply displayed in the console 
                    sw.WriteLine(responseText);

                    //close stream and socket
                    stream.Close();
                    socket.Close();
                }
                catch (Exception ex)
                {
                    //error message to user console
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
