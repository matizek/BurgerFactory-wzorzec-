using System.Runtime.Remoting.Messaging;

namespace BurgerFactory
{
    public class PolskaFabryka : FabrykaAbstrakcyjna
    {
        public override Bulka WypropdukujBulke()
        {
            var bulka = new PolskaBulka();
            bulka.RodzajBulki = "Maślna";
            return bulka;
        }

        public override Mieso WyproprodukujMieso()
        {
            var mieso = new PolskieMieso();
            mieso.RodzajMiesa = "Wołowo-wieprzowe";
            return mieso;
        }

        public override Ser WypropodukujSer()
        {
            var ser = new PolskiSer();
            ser.RodzajSera = "Żółty";
            return ser;
        }

        public override Sos WypropodukujSos()
        {
            var sos = new PolskiSos();
            sos.RodzajSosu = "Czosnkowy";
            return sos;
        }

        public override Surowka WypropodukujSurowke()
        {
            var surowka = new PolskaSurowka();
            surowka.RodzajSurowki = "Biała kapusta";
            return surowka;
        }

        public override Frytki WypropodukujFrytki()
        {
            var frytki = new Frytki();
            frytki.RodzajFrytek = "Proste";
            return frytki;
        }
    }
}