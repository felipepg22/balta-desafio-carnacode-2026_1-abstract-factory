namespace DesignPatternChallenge.PaymentGateways.Common;

public interface IPaymentLogger
{
    public void Log(string message);
}