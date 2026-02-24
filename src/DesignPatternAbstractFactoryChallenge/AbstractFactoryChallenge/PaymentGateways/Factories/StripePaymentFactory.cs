using AbstractFactoryChallenge.PaymentGateways.Common;
using AbstractFactoryChallenge.PaymentGateways.Gateways.Stripe;

namespace AbstractFactoryChallenge.PaymentGateways.Factories
{
    public class StripePaymentFactory : IPaymentGatewayFactory
    {
        public ICardValidator CreateCardValidator() => new StripeCardValidator();

        public IPaymentLogger CreatePaymentLogger() => new StripeLogger();

        public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();
    }
}

