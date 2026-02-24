// DESAFIO: Sistema de Pagamentos Multi-Gateway
// PROBLEMA: Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento
// (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger)
// O código atual está muito acoplado e dificulta a adição de novos gateways

using AbstractFactoryChallenge.PaymentGateways.Common;
using AbstractFactoryChallenge.PaymentGateways.Factories;

namespace AbstractFactoryChallenge
{
    // Contexto: Sistema de pagamentos que precisa trabalhar com diferentes gateways
    // Cada gateway tem sua própria forma de processar, validar e logar transações
    
    public class PaymentService
    {
        private readonly IPaymentGatewayFactory _factory;

        public PaymentService(IPaymentGatewayFactory factory)
        {
            _factory = factory;
        }

        public void ProcessPayment(decimal amount, string cardNumber)
        {
            // Solução: Usar factory para criar os componentes sem acoplamento
            var validator = _factory.CreateCardValidator();
            if (!validator.ValidateCard(cardNumber))
            {
                Console.WriteLine("Cartão inválido");
                return;
            }

            var processor = _factory.CreatePaymentProcessor();
            var result = processor.ProcessTransaction(amount, cardNumber);

            var logger = _factory.CreatePaymentLogger();
            logger.Log($"Transação processada: {result}");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pagamentos ===\n");

            // Solução: Passar a factory ao invés de uma string
            var pagSeguroService = new PaymentService(new PagSeguroPaymentFactory());
            pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

            Console.WriteLine();

            var mercadoPagoService = new PaymentService(new MercadoPagoPaymentFactory());
            mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

            Console.WriteLine();

            var stripeService = new PaymentService(new StripePaymentFactory());
            stripeService.ProcessPayment(300.00m, "4234567890123456");
        }
    }
}
