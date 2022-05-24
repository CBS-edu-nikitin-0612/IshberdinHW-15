using System;
/// <summary>
/// Создайте 2 интерфейса IPlayable и IRecodable. 
/// В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
///Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
///Написать программу, которая выполняет проигрывание и запись.
/// </summary>
namespace Task3
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            player.Record();
            player.Stop();

            //Delay
            Console.ReadKey();
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play...");
        }
        public void Pause()
        {
            Console.WriteLine("Pause...");
        }
        public void Stop()
        {
            Console.WriteLine("Stop...");
        }
        public void Record()
        {
            Console.WriteLine("Record...");
        }
    }
}
