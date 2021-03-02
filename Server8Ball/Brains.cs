using System;
using System.IO;


namespace Server8Ball
{
    public class Brains
    {
        //variables for file reading and random number instance
        const string EIGHTBALL_FILE = "eightBall.txt";
        string[] eightBallResponses;
        Random rand;

        /// <summary>
        /// initialize class
        /// </summary>
        public Brains()
        {
            //instance of random number
            rand = new Random();
        }
        /// <summary>
        /// load the file with a try catch
        /// </summary>
        public void LoadFile()
        {
            //try block
            try
            {
                //read all of the lines into the file variable
                eightBallResponses = File.ReadAllLines(EIGHTBALL_FILE);

            }
            //catch block
            catch (Exception ex)
            {
                //error message
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Generate a random response for the eight ball returns a string 
        /// </summary>
        /// <returns></returns>
        public string GetRandomEightballResp()
        {
            //use rand.next method to generate a new response to return 
            return eightBallResponses[rand.Next(eightBallResponses.Length)];
        }
    }
}
