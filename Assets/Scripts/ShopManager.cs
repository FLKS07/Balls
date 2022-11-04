using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour, IDataPersistence
{
    
    [Header("Coins")]
    public int currentCoins;
    public TextMeshProUGUI coinText;
    


    [Header("OwnedBackgrounds")]
    public bool ownBackground1;
    public bool ownBackground2;

    [Header("Buttons")]
    public TextMeshProUGUI button1;
    public TextMeshProUGUI button2;
    
    [Header("Misc")]
    public int currentSprite;
    public DataPersistenceManager dataManager;

    private AudioSource audioSource;

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

    void Start(){
        audioSource = GetComponent<AudioSource>();
        UpdateButtons();
    }

    void Update(){
        coinText.text = currentCoins.ToString();
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

        UpdateButtons();

    }

    void UpdateButtons(){
        if(ownBackground1 == true){
            button1.text = "USE";
            
        }
        if(ownBackground2 == true){
            button2.text = "USE";
        }
    }

    public void PlaySFX(AudioClip sfx){
        audioSource.PlayOneShot(sfx);
    }

}