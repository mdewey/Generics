namespace Generics
{
    public class Horse: ICanGallop
    {
        // can do???
        // can Gallop
        // can carry a rider
        public int NumberOfShoes { get; set; }
        public string ManeColor { get; set; }
        public string Breed { get; set; }
        public int MaxSpeed { get; set; }

        public void DecreaseSpeed(int deccel)
        {
           this.MaxSpeed -= deccel;
        }

        public void IncreaseSpeed(int accel)
        {
           this.MaxSpeed += accel;
        }
    }
}