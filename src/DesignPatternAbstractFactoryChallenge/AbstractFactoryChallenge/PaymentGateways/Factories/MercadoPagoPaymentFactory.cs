using AbstractFactoryChallenge.PaymentGateways.Common;
using AbstractFactoryChallenge.PaymentGateways.Gateways.MercadoPago;

namespace AbstractFactoryChallenge.PaymentGateways.Factories
{
    public class MercadoPagoPaymentFactory : IPaymentGatewayFactory
    {
        public ICardValidator CreateCardValidator() => new MercadoPagoCardValidator();

        public IPaymentLogger CreatePaymentLogger() => new MercadoPagoLogger();

        public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();
    }
}

