namespace WorldRank.Models;

public class Wallet
{
    private decimal _balance;
    public decimal Balance { 
        get => _balance;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Balance cannot be negative.");

            }
            _balance = value;
        }


        }


    public Currency Currency { get; }

    public bool IsBlocked { get; private set; }

    public Wallet(Currency currency)
    {
        Currency = currency;
        Balance = 0m; // decimal μηδέν
        IsBlocked = false;
    }
}