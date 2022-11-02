using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public GameController gameController;


    public void startCameraShake(float duration, float magnitude)
    {
        StartCoroutine(Shake(duration, magnitude));
    }


    public IEnumerator Shake(float duration, float magnitude)
    {
        Debug.Log("Shaked");

        Vector3 orignalPosition = transform.position;
        float elapsed = 0f;


        while (elapsed < duration)
        {
            if (gameController.isPaused == false && gameController.isGameOver == false)
            {
                elapsed = 999999999999999999f;
            }

            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(x, y, -10f);
            elapsed += Time.deltaTime;
            yield return 0;

        }


        transform.position = orignalPosition;
    }
}
