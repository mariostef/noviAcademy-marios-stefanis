namespace WorldRank.Interfaces;

public interface IPlayer
{
    int Id { get; set; }
    string Name { get; set; }
    int Score { get; }
}