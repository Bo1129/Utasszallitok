namespace Utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Repulo> repulok = new();
            foreach (var sor in File.ReadAllLines("utasszallitok.txt").Skip(1))
            {
                repulok.Add(new Repulo(sor));
            }

            //4. feladat
            Console.WriteLine($"4. feladat: Adatsorok száma: {repulok.Count}");

            //5.feladat
            int rep = 0;
            foreach (var r in repulok)
            {

                if (r.tipus == "Boeing")
                {
                    rep++;
                }
            }
            Console.WriteLine($"5.feladat: Boeing tipusok száma: {rep}");
        }
    }
}
