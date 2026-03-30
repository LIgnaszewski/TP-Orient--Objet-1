namespace TP_1;

class Program
{
    static void Main(string[] args)
    {
        Produit p1 = new Produit("A01", "Souris", 15.0);
        Console.WriteLine(p1);

        Produit p2 = new Produit("A01", "Souris", 15.0);
        Console.WriteLine(p2);

        Console.WriteLine(p1.Equals(p2));

        HashSet<Produit> panier = new HashSet<Produit>();
        panier.Add(p1);
        panier.Add(p2);
        Console.WriteLine(panier.Count);

        Console.WriteLine(panier.GetHashCode());
        Console.WriteLine(p2.GetType());

        Produit p3 = new ProduitPerissable("B05", "Lait", 15.0, 5);
        Console.WriteLine(p3.GetType());
    }
}
