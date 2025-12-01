namespace zenelejatszas
{
    class Zene
    {
        public string Cim;
        public string Eloado;
        public string Mufaj;
        public int HosszMp;

        public Zene(string cim, string eloado, string mufaj, int hosszMp)
        {
            Cim = cim;
            Eloado = eloado;
            Mufaj = mufaj;
            HosszMp = hosszMp;
        }

        public override string ToString()
        {
            return $"{Cim} - {Eloado} ({Mufaj}, {HosszMp} mp)";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // az első sor a fejléc → átugorjuk
            
            while (true)
            {
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. Keresés cím szerint");
                Console.WriteLine("2. Zene törlése");
                Console.WriteLine("3. Zene módosítása");
                Console.WriteLine("4. Új zene");
                Console.WriteLine("5. 3,5 percnél hosszabbak");
                Console.WriteLine("6. Csak Pop zenék");
                Console.WriteLine("7. Zenék betöltése");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return;
                    case "1":
                       
                       

                        break;
                    case "2":
                       
                        
                        break;
                    case "3":

                        break;
                    case "4":
                         break;
                    case "5":
                        
                        break;
                    case "6":
                        var popZenek = zenek
        

                       
                        break;
                    case "7":
                        
                        }
                        break;


                }
                Console.ReadKey();

            }
        }
    }
}

    