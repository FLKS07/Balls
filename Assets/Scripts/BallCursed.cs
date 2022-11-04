using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCursed : MonoBehaviour
{
    public GameController gameController;
    public CameraShake camShake;

    public float camShakeMagnitude;
    public float camShakeTime;


    public AudioClip[] ballCurseSound;

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (gameController.isGameOver == false && gameController.isPaused == false)
        {
            gameController.Lives -= 1;
            Destroy(gameObject);
            gameController.AudioS.PlayOneShot(ballCurseSound[gameController.currentBackgroundSprite]);
            camShake.startCameraShake(camShakeTime, camShakeMagnitude);
        }
    }
}
