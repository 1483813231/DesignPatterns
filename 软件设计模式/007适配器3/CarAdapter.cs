namespace _007适配器3
{
    public class CarAdapter:CarController
    {
        private Lamp lamp;
        private Sound sound;

        public CarAdapter()
        {
            lamp=new ConcreteLamp();
            sound=new ConcreteSound();
        }

        public override void Sound()
        {
            sound.Phonate();
        }

        public override void Lamp()
        {
            lamp.Twinkle();
        }
    }
}