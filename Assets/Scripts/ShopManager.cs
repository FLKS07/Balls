using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour, IDataPersistence
{
    public int currentSprite;
    public DataPersistenceManager dataManager;

    public void LoadData(GameData data)
    {
        this.currentSprite = data.currentSprite;
    }
    public void Savedata(ref GameData data)
    {
        data.currentSprite = this.currentSprite;
    }

    public void changeSprite(int sprite)
    {
        currentSprite = sprite;
        dataManager.SaveGame();
    }

}
