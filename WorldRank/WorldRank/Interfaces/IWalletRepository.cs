using WorldRank.Models;

namespace WorldRank.Interfaces;

public interface IWalletRepository
{
    void Add(Wallet wallet, int playerId);

    IEnumerable<Wallet> GetByPlayer(int playerId);
}