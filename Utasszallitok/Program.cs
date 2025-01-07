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
        }
    }
}
