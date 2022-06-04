using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTester : MonoBehaviour
{
    public static Scene scene;

    void Start()
    {
        var sceneConfig = new SceneConfigGame();
        scene = new Scene(sceneConfig);

        this.StartCoroutine(scene.InitializeRutine());
    }

    

    void Update()
    {
        if (!Bank.isInitialized)
            return;

        if (Input.GetKeyDown(KeyCode.A))
        {
            Bank.AddCoins(this, 5);
            Debug.Log($"Add 5 coins. Total {Bank.coins}");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Bank.SpendCoins(this, 10);
            Debug.Log($"Spend 10 coins. Total {Bank.coins}");
        }
    }
}
