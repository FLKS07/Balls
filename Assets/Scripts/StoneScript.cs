using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : MonoBehaviour
{
    public GameController gameController;

    int lives;

    private void Start()
    {
        lives = 5;
    }

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if(gameController.isGameOver == false && gameController.isPaused == false)
        {


            lives -= 1;
        }

        
    }

    private void Update()
    {
        if(lives <= 0)
        {
            Destroy(gameObject);
            gameController.Lives += 1;
            gameController.Points += 3;
        }
    }
}
