using System;

namespace GenerateurDePaveGlossateur
{
    public class Pave
    {
        /*
            La première ligne sanctionne le fait que le message a bien été compris et pris en compte, mais qu'au demeurant son auteur est un inconnu, s'ensuit la question de son identité.
            La deuxième ligne évoque le fait que personne ne connaît l'auteur ici.
            La troisième ligne prend à partie l'auteur en lui demandant de manière ironique si son intervention avait pour but de faire rire d'une quelconque manière.
            La quatrième ligne affirme que l'auteur déclenche un sentiment de malaise par son message inopportun, et le prie de quitter le topic.
            La cinquième ligne conclue le pavé par un retournement humoristique qui consiste à gratifier l'auteur d'une formule de politesse, d'un salut amical malgré les propos tenus
        */
        public List<Phrase> Phrases = new List<Phrase>();
        public Pave(List<Phrase> Phrases)
        {
            this.Phrases = Phrases;
        }
        public void Afficher()
        {
            foreach (Phrase phrase in Phrases)
            {

                foreach (var gp in phrase.GroupeNominal)
                {
                    Console.Write(gp.texte.ToLower());
                }

            }
        }
    }
    public class Phrase
    {
        public List<GroupeNominal> GroupeNominal;
        public Phrase(List<GroupeNominal> GroupeNominal)
        {
            this.GroupeNominal = GroupeNominal;
        }
    }
    public class GroupeNominal
    {
        public string texte = "";
        public GroupeNominal(string texte)
        {
            this.texte = texte;
            texte = texte.ToLower();
        }
    }

    class Program
    {
        static void Generer(bool sticker = false)
        {
            /*
                 nb gp dans première phrase : 3
                nb gp dans deuxieùe phrase : 4
                nb gp dans troisième phrase : 4
                nb gp dans quatrième p^hrase : 6
                nb gp dans cinquième phrase : 3
                 */
            var filename1 = "C:\\Users\\YourName\\source\\repos\\GenerateurDePaveGlossateur\\phrase1\\";
            var filename2 = "C:\\Users\\YourName\\source\\repos\\GenerateurDePaveGlossateur\\phrase2\\";
            var filename3 = "C:\\Users\\YourName\\source\\repos\\GenerateurDePaveGlossateur\\phrase3\\";
            var filename4 = "C:\\Users\\YourName\\source\\repos\\GenerateurDePaveGlossateur\\phrase4\\";
            var filename5 = "C:\\Users\\YourName\\source\\repos\\GenerateurDePaveGlossateur\\phrase5\\";
            var filename6 = "C:\\Users\\YourName\\source\\repos\\GenerateurDePaveGlossateur\\stickers\\";
            Random rand = new Random();

            string[] stickersArray = File.ReadAllLines(filename6 + "stickers.txt");
            List<string> stickers = new List<string>(stickersArray);

            //phrase 1 
            string[] p1gp1Array = File.ReadAllLines(filename1 + "gp1.txt");
            string[] p1gp2Array = File.ReadAllLines(filename1 + "gp2.txt");
            string[] p1gp3Array = File.ReadAllLines(filename1 + "gp3.txt");

            List<string> p1gp1 = new List<string>(p1gp1Array);
            List<string> p1gp2 = new List<string>(p1gp2Array);
            List<string> p1gp3 = new List<string>(p1gp3Array);


            //phrase 2

            string[] p2gp1Array = File.ReadAllLines(filename2 + "gp1.txt");
            string[] p2gp2Array = File.ReadAllLines(filename2 + "gp2.txt");
            string[] p2gp3Array = File.ReadAllLines(filename2 + "gp3.txt");
            string[] p2gp4Array = File.ReadAllLines(filename2 + "gp4.txt");

            List<string> p2gp1 = new List<string>(p2gp1Array);
            List<string> p2gp2 = new List<string>(p2gp2Array);
            List<string> p2gp3 = new List<string>(p2gp3Array);
            List<string> p2gp4 = new List<string>(p2gp4Array);


            //phrase 3
            string[] p3gp1Array = File.ReadAllLines(filename3 + "gp1.txt");
            string[] p3gp2Array = File.ReadAllLines(filename3 + "gp2.txt");
            string[] p3gp3Array = File.ReadAllLines(filename3 + "gp3.txt");
            string[] p3gp4Array = File.ReadAllLines(filename3 + "gp4.txt");

            List<string> p3gp1 = new List<string>(p3gp1Array);
            List<string> p3gp2 = new List<string>(p3gp2Array);
            List<string> p3gp3 = new List<string>(p3gp3Array);
            List<string> p3gp4 = new List<string>(p3gp4Array);

            // phrase 4
            string[] p4gp1Array = File.ReadAllLines(filename4 + "gp1.txt");
            string[] p4gp2Array = File.ReadAllLines(filename4 + "gp2.txt");
            string[] p4gp3Array = File.ReadAllLines(filename4 + "gp3.txt");
            string[] p4gp4Array = File.ReadAllLines(filename4 + "gp4.txt");
            string[] p4gp5Array = File.ReadAllLines(filename4 + "gp5.txt");
            string[] p4gp6Array = File.ReadAllLines(filename4 + "gp6.txt");

            List<string> p4gp1 = new List<string>(p4gp1Array);
            List<string> p4gp2 = new List<string>(p4gp2Array);
            List<string> p4gp3 = new List<string>(p4gp3Array);
            List<string> p4gp4 = new List<string>(p4gp4Array);
            List<string> p4gp5 = new List<string>(p4gp5Array);
            List<string> p4gp6 = new List<string>(p4gp6Array);

            // phrase 5
            string[] p5gp1Array = File.ReadAllLines(filename5 + "gp1.txt");
            string[] p5gp2Array = File.ReadAllLines(filename5 + "gp2.txt");
            string[] p5gp3Array = File.ReadAllLines(filename5 + "gp3.txt");

            List<string> p5gp1 = new List<string>(p5gp1Array);
            List<string> p5gp2 = new List<string>(p5gp2Array);
            List<string> p5gp3 = new List<string>(p5gp3Array);
            var phrases = new List<Phrase>();
            if (sticker)
            {
                phrases = new List<Phrase>()
                {
                    new Phrase(new List<GroupeNominal> {
                        new GroupeNominal( p1gp1[rand.Next(0, p1gp1.Count)]),
                        new GroupeNominal(p1gp2[rand.Next(0, p1gp2.Count)]),
                        new GroupeNominal(p1gp3[rand.Next(0, p1gp3.Count)] + stickers[rand.Next(0, stickers.Count)] +"\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    { new GroupeNominal( p2gp1[rand.Next(0, p2gp1.Count)]),
                        new GroupeNominal(p2gp2[rand.Next(0, p2gp2.Count)]),
                        new GroupeNominal(p2gp3[rand.Next(0, p2gp3.Count)]),
                        new GroupeNominal(p2gp4[rand.Next(0, p2gp4.Count)] + stickers[rand.Next(0, stickers.Count)] + "\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    {
                        new GroupeNominal(p3gp1[rand.Next(0, p3gp1.Count)]),
                        new GroupeNominal(p3gp2[rand.Next(0, p3gp2.Count)]),
                        new GroupeNominal(p3gp3[rand.Next(0, p3gp3.Count)]),
                        new GroupeNominal(p3gp4[rand.Next(0, p3gp4.Count)] + stickers[rand.Next(0, stickers.Count)] + "\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    {
                        new GroupeNominal( p4gp1[rand.Next(0, p4gp1.Count)]),
                        new GroupeNominal(p4gp2[rand.Next(0, p4gp2.Count)]),
                        new GroupeNominal(p4gp3[rand.Next(0, p4gp3.Count)]),
                        new GroupeNominal(p4gp4[rand.Next(0, p4gp4.Count)]),
                        new GroupeNominal(p4gp5[rand.Next(0, p4gp5.Count)]),
                        new GroupeNominal(p4gp6[rand.Next(0, p4gp6.Count)] + stickers[rand.Next(0, stickers.Count)] + "\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    {
                        new GroupeNominal( p5gp1[rand.Next(0, p5gp1.Count)]),
                        new GroupeNominal(p5gp2[rand.Next(0, p5gp2.Count)]),
                        new GroupeNominal(p5gp3[rand.Next(0, p5gp3.Count)] + stickers[rand.Next(0, stickers.Count)] + "\n\n"),
                    })
                };
            }
            else
            {
                phrases = new List<Phrase>()
                {
                    new Phrase(new List<GroupeNominal> {
                        new GroupeNominal( p1gp1[rand.Next(0, p1gp1.Count)]),
                        new GroupeNominal(p1gp2[rand.Next(0, p1gp2.Count)]),
                        new GroupeNominal(p1gp3[rand.Next(0, p1gp3.Count)] +"\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    { new GroupeNominal( p2gp1[rand.Next(0, p2gp1.Count)]),
                        new GroupeNominal(p2gp2[rand.Next(0, p2gp2.Count)]),
                        new GroupeNominal(p2gp3[rand.Next(0, p2gp3.Count)]),
                        new GroupeNominal(p2gp4[rand.Next(0, p2gp4.Count)] + "\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    {
                        new GroupeNominal( p3gp1[rand.Next(0, p3gp1.Count)]),
                        new GroupeNominal(p3gp2[rand.Next(0, p3gp2.Count)]),
                        new GroupeNominal(p3gp3[rand.Next(0, p3gp3.Count)]),
                        new GroupeNominal(p3gp4[rand.Next(0, p3gp4.Count)] + "\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    {
                        new GroupeNominal( p4gp1[rand.Next(0, p4gp1.Count)]),
                        new GroupeNominal(p4gp2[rand.Next(0, p4gp2.Count)]),
                        new GroupeNominal(p4gp3[rand.Next(0, p4gp3.Count)]),
                        new GroupeNominal(p4gp4[rand.Next(0, p4gp4.Count)]),
                        new GroupeNominal(p4gp5[rand.Next(0, p4gp5.Count)]),
                        new GroupeNominal(p4gp6[rand.Next(0, p4gp6.Count)] + "\n\n")
                    }),
                    new Phrase(new List<GroupeNominal>
                    {
                        new GroupeNominal( p5gp1[rand.Next(0, p5gp1.Count)]),
                        new GroupeNominal(p5gp2[rand.Next(0, p5gp2.Count)]),
                        new GroupeNominal(p5gp3[rand.Next(0, p5gp3.Count)] + "\n\n"),
                    })
                };
            }

            var pave = new Pave(phrases);
            pave.Afficher();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Generer(true);
                Console.WriteLine("\n\n\n");
            }

        }
    }
}
