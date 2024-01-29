using System.Reflection.Metadata;

namespace eserciziopomeridiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person gigi = new Person();
            gigi.Greet();
            Person pinco = new Person();
            pinco.Grow(20);
            pinco.Greet();
            Console.WriteLine( pinco.HowMuchTo18());
            pinco.TellHowMuchTo18();
            Animal wolf = new Animal();
            wolf.Gratta();
            Atleta pilota = new Atleta();
            pilota.Corsa();
            Dipendente lavoratore = new Dipendente();
            Console.WriteLine( lavoratore.QuantoAllaPensione());
            Veicolo golf = new Veicolo();
            golf.Rottamazione(55);
            golf.MyCar();
          


        }
    }

    public class Person
    {
       public int Height = 180;
       public string EyeColor = "Red";
       public int Age = 15; 
 
       public void Greet()
        {
            Console.WriteLine("Hi, my eye color is " + EyeColor + " " + Height.ToString());
        }
        public void Grow(int delta)
        {
            Height = Height + delta;
        }
       
        public int HowMuchTo18()
        {
            return 18 - Age;
        }

        public void TellHowMuchTo18()
        {
            Console.WriteLine("Ai 18 anni mancano " + HowMuchTo18());
        }


    }
    public class Animal
    {
        public int NumeroZampe = 4;
        public int Ferocia = 100;
        public string Comportamento = "Te mozzica";

        public void Gratta()
        {
            Console.WriteLine("Incontri un lupo con" + " " + NumeroZampe + " " + "zampe" + " " + " e " + Comportamento);
        }
    }

    public class Atleta
    {
        public string Qualita = "velocitá";
        public int VelocitáMax = 380;
        public string Protezione = "Casco";

        public void Corsa()
        {
            Console.WriteLine("Corre ad elevata" + " " + Qualita + " " + "raggiungendo i massimi di" + VelocitáMax + " " + " e " + " Indossando il " + " " + Protezione);
        }
    }

    public class Dipendente
    {
        public int AnniPensione = 50;
        public int NumeroAnniLavoro = 5;
        public string Qualifica = "Senior";


        public int QuantoAllaPensione()
        {
            return AnniPensione - NumeroAnniLavoro;
        }
    }


    public class Veicolo
    {
        public int NumeroRuote = 4;
        public int Immatricolazione= 1995;
        public string Carburante = "Benzina";

        public void MyCar()
        {
            Console.WriteLine("La mia auto va a " + " " + Carburante + " " + " e ha numero di ruote " + NumeroRuote + " " + Immatricolazione.ToString());
        }
        public void Rottamazione(int ban)
        {
            Immatricolazione = Immatricolazione + ban;
        }
       
    }
}
