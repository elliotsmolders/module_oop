public class Account
{
    private string _naam;
    public string Naam
    {
        get { return _naam; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                _naam = value;
            }
        }
    }
    private int _bedrag;
    public int Bedrag
    {
        get { return _bedrag; }
        set
        {
            if (value >= 0)
            {
                _bedrag = value;
            }
        }
    }
    private string _rekeningNummer;
    public string RekeningNummer
    {
        get { return _rekeningNummer; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                _rekeningNummer = value;
            }
        }
    }
    private AccountStates _accountState;
    public AccountStates AccountState
    {
        get { return _accountState; }
        set { _accountState = value; }
    }

    public int WithdrawFunds(int amount)
    {
        if (amount >= _bedrag || amount < 0)
        {
            System.Console.WriteLine("error");
        }
        else
        {
            Bedrag -= amount;
        }
        return _bedrag;
    }

    public void PayInFunds(int amount)
    {
        if (amount >= 0)
        {
            Bedrag += amount;
        }
        else
        {
            System.Console.WriteLine("Cannot Pay a negative amount");
        }
    }

    public int GetFunds()
    {
        return _bedrag;
    }

    public void ChangeState(AccountStates state)
    {
        if (state == AccountStates.Geldig)
        {
            AccountState = AccountStates.Geblokkeerd;
        }
        else
        {
            AccountState = AccountStates.Geldig;
        }
    }

    public void TransferMoney(Account toAccount, int amount)
    {
        if (
            AccountState == AccountStates.Geblokkeerd
            || toAccount.AccountState == AccountStates.Geblokkeerd
        )
        {
            System.Console.WriteLine("Error, one of the accounts is blocked");
            return;
        }

        if (this._bedrag <= amount)
        {
            System.Console.WriteLine("Error, Insufficient funds for transfer");
            return;
        }
        {
            this.WithdrawFunds(amount);
            toAccount.PayInFunds(amount);
        }
    }
}
