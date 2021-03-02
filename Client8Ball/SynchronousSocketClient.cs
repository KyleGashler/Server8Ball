using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client8Ball
{
    class SynchronousSocketClient
    {
        //variables 
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";


        public string ContactServer(string userinput)
        {
            //variable for rsponse
            string responseString = "";
            //try catch for response read and write and connection to tcp
            try
            {
                //new instance of tcp client
                TcpClient tcpClient = new TcpClient();

                //connect to tcp client using ip and port
                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), PORT);
                //connects to open port and gets stream to be read and written to
                NetworkStream networkStream = tcpClient.GetStream();

                //stream reader and writer for network stream
                StreamReader sr = new StreamReader(networkStream);
                StreamWriter sw = new StreamWriter(networkStream);

                //autoflush sw
                sw.AutoFlush = true;

                //write according to user input
                sw.WriteLine(userinput);
                //read line that will feed into text box
                responseString = sr.ReadLine();
                //close open connections
                networkStream.Close();
                tcpClient.Close();

            }
            catch (Exception ex)
            {
                //response error
                responseString = ex.Message;
            }

            //return the responseString
            return responseString;
        }
    }
}
