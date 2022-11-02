using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData{
    public int maxPoints;
    public int coins;
    public int currentSprite;
    

    public GameData(){
        this.maxPoints = 0;
        this.coins = 0;
        this.currentSprite = 0;
    }
}