using WorldRank.Interfaces;
using WorldRank.Models;

namespace WorldRank.Repositories;

public class InMemoryWalletRepository : IWalletRepository
{
    private readonly Dictionary<int, List<Wallet>> _walletsByPlayer = new();

    public void Add(Wallet wallet, int playerId)
    {
        if (!_walletsByPlayer.ContainsKey(playerId))
        {
            _walletsByPlayer[playerId] = new List<Wallet>();
        }

        List<Wallet> playerWallets = _walletsByPlayer[playerId];

        bool walletAlreadyExists =
            playerWallets.Any(w => w.Currency == wallet.Currency);

        if (walletAlreadyExists)
        {
            throw new InvalidOperationException(
                "The player already has a wallet in this currency.");
        }

        playerWallets.Add(wallet);
    }
    public IEnumerable<Wallet> GetByPlayer(int playerId)
    {
        if (_walletsByPlayer.ContainsKey(playerId))
        {
            return _walletsByPlayer[playerId];
        }

        return new List<Wallet>();
    }
}