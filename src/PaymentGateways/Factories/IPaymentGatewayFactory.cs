using DesignPatternChallenge.PaymentGateways.Common;

namespace DesignPatternChallenge.PaymentGateways.Factories;
public interface IPaymentGatewayFactory
{
    ICardValidator CreateCardValidator();
    IPaymentLogger  CreatePaymentLogger();
    IPaymentProcessor CreatePaymentProcessor();
}