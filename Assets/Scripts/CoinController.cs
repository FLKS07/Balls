using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameController gameController;

    public AudioClip audioClip;


    void OnMouseDown(){
        if(gameController.isPaused == false && gameController.isGameOver == false){
            gameController.AudioS.PlayOneShot(audioClip);
            gameController.Coins +=1;
            Destroy(gameObject);
        }
    }

    
}
