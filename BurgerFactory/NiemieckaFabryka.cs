namespace BurgerFactory
{
    public class NiemieckaFabryka : FabrykaAbstrakcyjna
    {
        public override Bulka WypropdukujBulke()
        {
            var bulka = new NiemieckaBulka();
            bulka.RodzajBulki = "Przenna";
            return bulka;
        }

        public override Mieso WyproprodukujMieso()
        {
            var mieso = new NiemieckieMieso();
            mieso.RodzajMiesa = "Wołowe";
            return mieso;
        }

        public override Ser WypropodukujSer()
        {
            var ser = new NiemieckiSer();
            ser.RodzajSera = "Kozi";
            return ser;
        }

        public override Sos WypropodukujSos()
        {
            var sos = new NiemieckiSos();
            sos.RodzajSosu = "Ketchup";
            return sos;
        }

        public override Surowka WypropodukujSurowke()
        {
            var surowka = new NiemieckaSurowka();
            surowka.RodzajSurowki = "Kapusta";
            return surowka;
        }

        public override Frytki WypropodukujFrytki()
        {
            var frytki = new Frytki();
            frytki.RodzajFrytek = "Kręcone";
            return frytki;
        }
    }
}