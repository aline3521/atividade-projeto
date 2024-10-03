// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace VoadorPairador
{
    public interface IVoador
    {
        void Voar();
    }
    public interface IPairador
    {
        void Pairar();
    }
    public class Passarinho : IVoador, IPairador
    {
        public void Voar()
        {
            Console.WriteLine("O passarinho está voando!");
        }
        public void Pairar()
        {
            Console.WriteLine("O passarinho está pairando no ar!");
        }
    }
    public class Aviao : IVoador
    {
        public void Voar()
        {
            Console.WriteLine("O avião está voando!");
        }
    }
    public class Helicoptero : IVoador, IPairador
    {
        public void Voar()
        {
            Console.WriteLine("O helicóptero está voando!");
        }
        public void Pairar()
        {
            Console.WriteLine("O helicóptero está pairando no ar!");
        }
    }
    public class DiscoVoador : IVoador
    {
        public void Voar()
        {
            Console.WriteLine("O disco voador está voando!");
        }
    }
    public class SuperHomem : IVoador, IPairador
    {
        public void Voar()
        {
            Console.WriteLine("O Super-Homem está voando!");
        }
        public void Pairar()
        {
            Console.WriteLine("O Super-Homem está pairando no ar!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IVoador[] voadores = new IVoador[]            {
                new Passarinho(),                new Aviao(),
                new Helicoptero(),                new DiscoVoador(),
                new SuperHomem()            };
            IPairador[] pairadores = new IPairador[]
            {                new Passarinho(),
                new Helicoptero(),                new SuperHomem()
            };
            Console.WriteLine("Voadores:"); foreach (var voador in voadores)
            {
                Console.WriteLine($"Tipo: {voador.GetType().Name}");
                voador.Voar(); Console.WriteLine();
            }
            Console.WriteLine("Pairadores:"); foreach (var pairador in pairadores)
            {
                Console.WriteLine($"Tipo: {pairador.GetType().Name}");
                pairador.Pairar(); Console.WriteLine();
            }
        }
    }
}