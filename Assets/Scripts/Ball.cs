using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameController gameController;

    public AudioClip pop;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if(gameController.isGameOver == false && gameController.isPaused == false)
        {
            Destroy(gameObject);
            gameController.Points += 1;
            gameController.AudioS.PlayOneShot(pop);
        }
        else if(gameController.isGameOver == true && gameController.isPaused == true)
        {
            return;
        }

        
    }
}
