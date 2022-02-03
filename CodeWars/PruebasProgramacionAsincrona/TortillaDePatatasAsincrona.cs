using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars.PruebasProgramacionAsincrona
{
    public class TortillaDePatatasAsincrona
    {
        public async Task CocinaTortilla()
        {
            Sarten sarten = await BuscaSarten();
            Console.WriteLine("Sarten encontrada, es necesario calentarla");

            Console.WriteLine("Mientras se calienta la sarten, buscare las patatas y los huevos");
            Task<Sarten> calientaSarten = CalientaSarten(sarten);
            Task<Patata[]> buscaPatatas = BuscaPatatas(5);
            Task<Huevo[]> buscaHuevos = BuscaHuevos(2);

            await Task.WhenAll(calientaSarten, buscaHuevos, buscaPatatas);
            Console.WriteLine("Ahora que la sarten esta caliente y tengo los huevos y las patatas, pelare y freire las patatas");
            sarten = await calientaSarten;
            Huevo[] Huevos = await buscaHuevos;
            Patata[] Patatas = await buscaPatatas;
            
        }

        private async Task<Sarten> BuscaSarten()
        {
            Console.WriteLine("Voy a buscar la sarten a la alacena");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Sigo buscando la sarten en la alacena...");
            }

            return new Sarten();
        }

        private async Task<Sarten> CalientaSarten(Sarten sarten)
        {
            sarten.CalientaSarten();
            return sarten;
        }

        private async Task<Patata[]> BuscaPatatas(int numeroPatatas)
        {
            Console.WriteLine("Cogere las patatas");
            Thread.Sleep(100*numeroPatatas);
            Patata[] Patatas = new Patata[numeroPatatas];
            Console.WriteLine("He cogido las {0} patata(s)", numeroPatatas);

            return Patatas;
        }

        private async Task<Huevo[]> BuscaHuevos(int numeroHuevos)
        {
            Console.WriteLine("Cogere las huevos");
            Thread.Sleep(100 * numeroHuevos);
            Huevo[] Huevos = new Huevo[numeroHuevos];
            Console.WriteLine("He cogido los {0} huevo(s)", numeroHuevos);

            return Huevos;
        }

        private class Sarten
        {
            public bool IsCaliente { get; set; }

            public Sarten()
            {
                IsCaliente = false;
            }

            public void CalientaSarten()
            {
                Console.WriteLine("Calentando sarten...");
                Thread.Sleep(5000);
                Console.WriteLine("Sarten caliente");
                IsCaliente = true;
            }
        }

        private class Patata
        {
            public bool IsPelada { get; set; }
            public bool IsFrita { get; set; }

            public Patata()
            {
                IsPelada = false;
                IsFrita = false;
            }

            public void PelarPatata()
            {
                Console.WriteLine("Pelando patata...");
                Thread.Sleep(100);
                Console.WriteLine("Patata pelada");
                IsPelada = true;
            }
        }

        private class Huevo
        {
            public bool IsBatido { get; set; }

            public Huevo()
            {
                IsBatido = false;
            }

            public void PelarPatata()
            {
                Console.WriteLine("Batiendo huevo...");
                Thread.Sleep(100);
                Console.WriteLine("Huevo batido");
                IsBatido = true;
            }
        }
    }
}
