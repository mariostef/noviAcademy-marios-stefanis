using WorldRank.Application.Strategies;
using WorldRank.Domain.Player;
using WorldRank.Domain.Wallets;

namespace WorldBank.Application.Strategies;

public class AddFundsStrategy : IFundsStrategy
{
    public FundsOperation Operation => FundsOperation.Add;
    public void Execute(Wallet wallet, decimal amount) => wallet.Deposit(amount);
}
