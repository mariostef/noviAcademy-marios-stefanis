
using WorldRank.Domain.Player;
using WorldRank.Domain.Wallets;
using WorldRank.Application.Strategies;

namespace WorldBank.Application.Strategies;

public class ForceSubtract : IFundsStrategy
{
    public FundsOperation Operation => FundsOperation.ForceSubtract;
    public void Execute(Wallet wallet, decimal amount) => wallet.ForceWithdraw(amount);
}
