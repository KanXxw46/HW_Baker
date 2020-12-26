using System;

namespace Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            Barista barista = new Barista();
            BakerBuilder coffeeBuilder = new Bread();
            var capuchino = barista.Make(coffeeBuilder);
            Console.WriteLine(capuchino.ToString());

            BakerMaking someBread = new Bread();
            someBread.Make();
        }
    }
}
