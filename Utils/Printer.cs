using static System.Console;
namespace Coreschool.Util
{
    public static class Printer

    {
        public static void DrawLine(int tam =10 )
        {
            WriteLine("".PadLeft(tam, '='));
        }
        public static void WriteTitle(string titulo)
        {
            var lenght =titulo.Length + 4;
            DrawLine(lenght);
            WriteLine($"|| {titulo} ||");
            DrawLine(lenght);
        }
        public static void Beep(int hz = 2000, int time=500, int count =1)
        {
            while (count-- > 0)
            {
                System.Console.Beep(hz, time);
            }
        }

        

    }
}