namespace Generics
{
    public interface ICanGallop{
        int NumberOfShoes { get; set; }
        int MaxSpeed {get;set;}

        void IncreaseSpeed(int accel);
        void DecreaseSpeed(int deccel);
    }

}