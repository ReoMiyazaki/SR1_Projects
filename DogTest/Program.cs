using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dogクラスのインスタンス hachi を生成する
            Dog hachi = new Dog();
            hachi.Brak();

            Dog pochi = new Dog();
            pochi.Brak();
            pochi.Run();

            // 一時停止
            Console.ReadLine();
        }
    }
}
