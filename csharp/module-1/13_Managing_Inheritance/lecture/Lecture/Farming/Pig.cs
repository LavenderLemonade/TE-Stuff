namespace Lecture.Farming
{
    public class Pig : FarmAnimal, ISellable
    {
        public decimal Price { get; }

        public Pig() : base("Pig", "oink")
        {
            Price = 300;
        }

        public override string Eat()
        {
            return "mmm mmm mm, I'm in Charlotte's Web";
        }
    }
}
