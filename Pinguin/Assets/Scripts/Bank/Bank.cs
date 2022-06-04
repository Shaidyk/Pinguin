using System;
using System.Collections.Generic;

public static class Bank
{
    public static event Action OnBankInitializedEvent;
    private static BankInteractor bankInteractor;


    public static int coins { 
        get
        {
            CheckCalss();
            return bankInteractor.coins;
        } 
    }

    public static bool isInitialized { get; private set; }



    public static void Initialize(BankInteractor interactor)
    {
        bankInteractor = interactor;
        isInitialized = true;
        OnBankInitializedEvent?.Invoke();
    }

    public static bool IsEnoughCoins(int value)
    {
        CheckCalss();
        return bankInteractor.IsEnoughCoins(value);
    }

    public static void AddCoins(object sender, int value)
    {
        CheckCalss();
        bankInteractor.AddCoins(sender, value);
    }

    public static void SpendCoins(object sender, int value)
    {
        CheckCalss();
        bankInteractor.SpendCoins(sender, value);

    }

    private static void CheckCalss()
    {
        if (!isInitialized)
            throw new Exception("Bank is not initialize yet");
    }
}
