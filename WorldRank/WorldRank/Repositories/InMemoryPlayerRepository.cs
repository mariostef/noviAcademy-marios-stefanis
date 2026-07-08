using System.Numerics;
using WorldRank;
using WorldRank.Interfaces;

namespace WorldRank.Repositories
{
    public class InMemoryPlayerRepository : IPlayerRepository
    {
        private readonly Dictionary<int, Player> _players = new Dictionary<int, Player>();
        public void AddPlayer(Player player)
        {
            if (!(_players.ContainsKey(player.Id)))
            {
                _players.Add(player.Id, player);

            }

        }
        public Player? FindPlayer(int playerId)
        {
            if (_players.ContainsKey(playerId))
            {
                return _players[playerId];

            }

            return null;
        }
        public void DeletePlayer(int playerId)
        {
            if (_players.ContainsKey(playerId))
            {
                _players.Remove(playerId);

            }
        }
    }
}
    


