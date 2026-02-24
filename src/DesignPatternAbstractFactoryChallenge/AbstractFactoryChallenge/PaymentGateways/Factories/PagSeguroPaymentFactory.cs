using AbstractFactoryChallenge.PaymentGateways.Common;
using AbstractFactoryChallenge.PaymentGateways.Gateways;

namespace AbstractFactoryChallenge.PaymentGateways.Factories
{
    public class PagSeguroPaymentFactory : IPaymentGatewayFactory
    {
        public ICardValidator CreateCardValidator() => new PagSeguroCardValidator();

        public IPaymentLogger CreatePaymentLogger() => new PagSeguroLogger();

        public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();
    }
}