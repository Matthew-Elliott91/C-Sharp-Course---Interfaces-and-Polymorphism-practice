namespace Interfaces_and_Polymorphism_practice
{
    internal class Program
    {
        public interface IPaymentProcesser
        {
            void ProcessPayment(decimal amount);
            
        }

        public class CreditCardProcessor : IPaymentProcesser
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing credit card payment of £{amount}. ");
                //Implement credit card payment logic
            }
            
        }

        public class  PayPalProcessor : IPaymentProcesser 
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Proccessing the paypal payment of £{amount}");
                //Implement paypal payment logic
            }
           
        }

        public class PaymentService
        {
            private readonly IPaymentProcesser _paymentProcesser;

            public PaymentService(IPaymentProcesser processor)
            {
                _paymentProcesser = processor;
            }
            public void ProcessOrderPayment(decimal amount)
            {
                _paymentProcesser.ProcessPayment(amount);
            }
        }
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
            IPaymentProcesser creditCardProcessor = new CreditCardProcessor();
            PaymentService creditCardPaymentService = new PaymentService(creditCardProcessor);
            creditCardPaymentService.ProcessOrderPayment(100);

            CreditCardProcessor newCreditCardProcessor = new CreditCardProcessor();
            newCreditCardProcessor.ProcessPayment(100);


        }
    }
}
