using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData{
    public int maxPoints;
    public int coins;
    public int currentSprite;
    
    public bool ownBackground1;
    public bool ownBackground2;
    

    public GameData(){
        this.maxPoints = 0;
        this.coins = 0;
        this.currentSprite = 0;
        
        this.ownBackground1 = true;
        this.ownBackground2 = false;
    }
}