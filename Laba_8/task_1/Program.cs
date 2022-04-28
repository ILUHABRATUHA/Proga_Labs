using System;

namespace task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Airport Domodedovo = Airport.CreateAirport("Domodedovo");
            Tariff tariff = new Tariff("Moscow", "London", "250");
            SpecialTariff spc_tar = new SpecialTariff("Paris", "Vitebsk", "440", "30");

            Domodedovo.Add(tariff);
            Domodedovo.Add(spc_tar);

            Domodedovo.Show(); 
            Domodedovo.ShowSpecial();

            int a = Domodedovo.MaxTariff();
            Console.WriteLine(a);
        }
    }
}
