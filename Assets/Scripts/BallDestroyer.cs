using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    public GameController gameController;
    public AudioClip oOf;


    [Header("CameraShake")]
    public CameraShake cameraShake;

    public float magnitude;
    public float duration;



    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GoodBall")
        {
            Destroy(collision.gameObject);
            gameController.Lives -= 1;
            gameController.Points -= 5;
            gameController.AudioS.PlayOneShot(oOf);
            cameraShake.startCameraShake(duration, magnitude);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
