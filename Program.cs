using System.Net.Http.Headers;

namespace Inheritance_Justin_palmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prints E and ZombCube.
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            //Prints M and CS:GO.
            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}