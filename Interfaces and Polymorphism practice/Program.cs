namespace Interfaces_and_Polymorphism_practice
{
    internal class Program
    {
        public interface IAnimal
        {
            void MakeSound();
            void Eat(string food);

        }

        public class Dog : IAnimal
        {
            public void Eat(string food)
            {
                Console.WriteLine($"Dog ate the {food} ");
            }

            public void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        public class Cat : IAnimal
        {
            public void Eat(string food)
            {
                Console.WriteLine($"Cat ate the {food} ");
            }
            public void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Treat");
        }
    }
}
