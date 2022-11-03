using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour, IDataPersistence
{
    

    public int currentCoins;
    public int currentSprite;
    public DataPersistenceManager dataManager;


    [Header("OwnedBackgrounds")]
    public bool ownBackground1;
    public bool ownBackground2;

    public void LoadData(GameData data)
    {
        this.currentCoins = data.coins;
        this.currentSprite = data.currentSprite;

         // Below here are the backgrounds
        this.ownBackground1 = data.ownBackground1;
        this.ownBackground2 = data.ownBackground2;
    }
    public void Savedata(ref GameData data)
    {
        data.coins = this.currentCoins;
        data.currentSprite = this.currentSprite;

        // Bellow here are the backgrounds
        data.ownBackground1 = this.ownBackground1;
        data.ownBackground2 = this.ownBackground2;
        
    }

    public void changeSprite(int sprite)
    {
        
        
        
        if(sprite == 0){
            currentSprite = sprite;
            dataManager.SaveGame();
            ownBackground1 = true;
            
        }
        else if(sprite == 1 && currentCoins >= 2){
            if(currentCoins >= 2 && ownBackground2 == false){
                currentSprite = sprite;
                dataManager.SaveGame();
                currentCoins = currentCoins -2;
                ownBackground2 = true;
            }
            else if(ownBackground2 == true){
                currentSprite = sprite;
                dataManager.SaveGame();
            }
        }

    }

}
