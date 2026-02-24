using AbstractFactoryChallenge.PaymentGateways.Common;

namespace AbstractFactoryChallenge.PaymentGateways.Factories
{
    public interface IPaymentGatewayFactory
    {
        ICardValidator CreateCardValidator();
        IPaymentLogger  CreatePaymentLogger();
        IPaymentProcessor CreatePaymentProcessor();
    }
}