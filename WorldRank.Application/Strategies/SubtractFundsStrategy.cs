using WorldRank.Application.Strategies;
using WorldRank.Domain.Player;
using WorldRank.Domain.Wallets;

namespace WorldBank.Application.Strategies;

public class SubtractFundsStrategy : IFundsStrategy
{
    public FundsOperation Operation => FundsOperation.Subtract;
    public void Execute(Wallet wallet, decimal amount) => wallet.Withdraw(amount);
}
