namespace prima_lezione_b
{
    internal class Program
    {

        static void Main()
            {
                Atleta atleta = new Atleta("Marco", "Calcio", 5);
                Dipendente dipendente = new Dipendente("Giulia", "Contabile", 2018);
                Animale animale = new Animale("Cane", "Fido", 3);
                Veicolo veicolo = new Veicolo("Fiat", "500", 2020);

                atleta.StampaInfo();
                dipendente.StampaInfo();
                animale.StampaInfo();
            veicolo.StampaInfo();
            }
        }
    }
    public class Atleta
    {
        public string Nome { get; set; }
        public string Sport { get; set; }
        public int AnniDiEsperienza { get; set; }

        public Atleta(string nome, string sport, int anniDiEsperienza)
        {
            Nome = nome;
            Sport = sport;
            AnniDiEsperienza = anniDiEsperienza;
        }

        public void StampaInfo()
        {
            Console.WriteLine($"Atleta: {Nome}, Sport: {Sport}, Anni di Esperienza: {AnniDiEsperienza}");
        }
    }
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Posizione { get; set; }
        public int AnnoDiAssunzione { get; set; }

        public Dipendente(string nome, string posizione, int annoDiAssunzione)
        {
            Nome = nome;
            Posizione = posizione;
            AnnoDiAssunzione = annoDiAssunzione;
        }

        public void StampaInfo()
        {
            Console.WriteLine($"Dipendente: {Nome}, Posizione: {Posizione}, Anno di Assunzione: {AnnoDiAssunzione}");
        }
    }

    public class Animale
    {
        public string Specie { get; set; }
        public string Nome { get; set; }
        public int Eta { get; set; }

        public Animale(string specie, string nome, int eta)
        {
            Specie = specie;
            Nome = nome;
            Eta = eta;
        }

        public void StampaInfo()
        {
            Console.WriteLine($"Animale: {Nome}, Specie: {Specie}, Età: {Eta}");
        }
    }
    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public Veicolo(string marca, string modello, int anno)
        {
            Marca = marca;
            Modello = modello;
            Anno = anno;
        }

        public void StampaInfo()
        {
            Console.WriteLine($"Veicolo: {Marca}, Modello: {Modello}, Anno: {Anno}");
        }
    }
    






