using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    [Header("GameController")]
    public GameController gameController;
    [Header("Audio")]
    public AudioClip audioClip;

    void OnMouseDown(){
        if(gameController.isGameOver == false && gameController.isPaused == false){
            gameController.AudioS.PlayOneShot(audioClip);
            gameController.Lives +=1;
            Destroy(gameObject);
        }
    }

    
}
