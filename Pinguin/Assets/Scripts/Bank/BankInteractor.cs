using UnityEngine;

public class BankInteractor : Interactor
{
    private BankRepository repository;

    public int coins => this.repository.coins;

    public override void OnCreate()
    {
        this.repository = MoneyTester.scene.GetRepository<BankRepository>();

    }

    public override void Initialize()
    {
        Bank.Initialize(this);
    }

    public bool IsEnoughCoins(int value)
    {
        return coins >= value;
    }

    public void AddCoins(object sender, int value)
    {
        this.repository.coins += value;
        this.repository.Save();
    }

    public void SpendCoins(object sender, int value)
    {
        this.repository.coins -= value;
        this.repository.Save();
    }
}

