namespace Generics
{
  public interface ICanFly
    {
        int WingSpan { get; set; }
        int FlySpeed { get; set; }
        int CurrentFlyingSpeed{get;set;}

        void FlapWings();

        void Glide();
    }
}