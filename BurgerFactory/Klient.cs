namespace BurgerFactory
{
    public class Klient
    {
        private Bulka _bulka;
        private Mieso _mieso;
        private Ser _ser;
        private Sos _sos;
        private Surowka _surowka;
        private Frytki _frytki;

        public Klient(FabrykaAbstrakcyjna fabrykaAbstrakcyjna)
        {
            _bulka = fabrykaAbstrakcyjna.WypropdukujBulke();
            _mieso = fabrykaAbstrakcyjna.WyproprodukujMieso();
            _ser = fabrykaAbstrakcyjna.WypropodukujSer();
            _sos = fabrykaAbstrakcyjna.WypropodukujSos();
            _surowka = fabrykaAbstrakcyjna.WypropodukujSurowke();
            _frytki = fabrykaAbstrakcyjna.WypropodukujFrytki();
        }

        public override string ToString()
        {
            return $"| Rodzaj bułki: {_bulka.RodzajBulki} \n| Rodzaj Mięsa: {_mieso.RodzajMiesa} \n| Rodzaj Sera: {_ser.RodzajSera} \n| Rodzaj Sosu: {_sos.RodzajSosu} \n| Rodzaj surówki: {_surowka.RodzajSurowki} \n| Rodzaj Frytek: {_frytki.RodzajFrytek}";
        }

    }
}