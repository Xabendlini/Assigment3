namespace Assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlcoholOfChoice Milani = new AlcoholOfChoice("Henessy", 6, true);
            Console.WriteLine("Milani" + " " + Milani.GetAlcoholChoice());


            AlcoholOfChoice Gaba = new AlcoholOfChoice("Heineken", 12, false);
            Console.WriteLine("Gaba"+ " " + Gaba.GetAlcoholChoice());


            AlcoholOfChoice Olwethu = new AlcoholOfChoice("Breezer", 6, false);
            Console.WriteLine("Olwethu" + " " + Olwethu.GetAlcoholChoice());

            Console.WriteLine("GLASSES" + " " + Milani.GetNumberOfDrinks());
            Console.WriteLine("GLASSES" + " " + Gaba.GetNumberOfDrinks());
            Console.WriteLine("GLASSES" + " " + Olwethu.GetNumberOfDrinks());   

            Console.WriteLine(" DOES IT HAVE ICE? " + " " + Milani.GetIceOrNoIce());
            Console.WriteLine(" DOES IT HAVE ICE? " + " " + Gaba.GetIceOrNoIce());
            Console.WriteLine(" DOES IT HAVE ICE? " + " " + Olwethu.GetIceOrNoIce());
        }
    }
}
