using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Sekil
        {
            public virtual void Draw()
            {
                Console.WriteLine("Belirtilen Şekil Çiziliyor.");
            }
        }

        public class Daire : Sekil
        {
            public override void Draw()
            {
                Console.WriteLine("Bir Daire Çiz.");
                base.Draw();
            }
        }

        public class Kare : Sekil
        {
            public override void Draw()
            {
                Console.WriteLine("Bir Kare Çiz.");
                base.Draw();
            }
        }

        public class Dikdortgen : Sekil
        {
            public override void Draw()
            {
                Console.WriteLine("Bir Dikdörtgen Çiz.");
                base.Draw();
            }
        }

        public class Ucgen : Sekil
        {
            public override void Draw()
            {
                Console.WriteLine("Bir Üçgen Çiz.");
                base.Draw();
            }
        }

        static void Main(string[] args)
        {
            var sekiller = new List<Sekil>()
            {
                new Daire(),
                new Kare(),
                new Dikdortgen(),
                new Ucgen()
            };

            foreach (var sekil in sekiller)
            {
                sekil.Draw();
            }
        }
    }
}
