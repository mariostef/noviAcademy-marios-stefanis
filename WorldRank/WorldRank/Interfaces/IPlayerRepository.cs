using WorldRank;

namespace WorldRank.Interfaces;

public interface IPlayerRepository
{
    void AddPlayer(Player player);
    Player? FindPlayer(int playerId);
    void DeletePlayer(int playerId);

}