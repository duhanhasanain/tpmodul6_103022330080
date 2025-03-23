// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;
using tpmodul6_103022330080;


internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Duhan Hasanain");
        try
        {
            for (int i = 0; i < 100000; i++)
            {
                video.IncreasePlayCount(100000001, video.GetDebug());
                Console.WriteLine();
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        video.PrintVideoDetails();
    }
}