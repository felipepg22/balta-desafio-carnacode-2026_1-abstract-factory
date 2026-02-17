namespace AbstractFactoryChallenge.PaymentGateways.Common;

public interface IPaymentLogger
{
    public void Log(string message);
}