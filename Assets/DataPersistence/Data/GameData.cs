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
    public bool ownBackground3;
    

    public GameData(){
        this.maxPoints = 0;
        this.coins = 0;
        this.currentSprite = 0;
        
        this.ownBackground1 = true; // <- This sould always be true, it's the default background
        this.ownBackground2 = false;
        this.ownBackground3 = false;
        
    }
}