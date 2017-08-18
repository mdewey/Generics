using System;

namespace Generics
{
   public class Pegasus : ICanGallop, ICanFly
    {
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlyingSpeed { get ; set ; }
        public int NumberOfShoes { get ; set ; }
        public int MaxSpeed { get ; set ; }

        public void DecreaseSpeed(int deccel)
        {
            this.MaxSpeed -= deccel *2; 
        }

        public void FlapWings()
        {
           this.CurrentFlyingSpeed += this.FlySpeed * 2;
        }

        public void Fly()
        {
           Console.WriteLine("Flying away");
        }

        public void Glide()
        {
            this.CurrentFlyingSpeed -= this.FlySpeed;
        }

        public void IncreaseSpeed(int accel)
        {
          this.MaxSpeed += accel * 2;
        }
    }

}