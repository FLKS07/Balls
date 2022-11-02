using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField] int lives;
    [SerializeField] Sprite boxImage;
    [SerializeField] AudioClip punch;
    [SerializeField] float punchVolume;

    public GameController gameController;

    public GameObject[] objects;

    SpriteRenderer boxRenderer;

    [Header("Cam Shake")]
    public CameraShake camShake;
    public float camTime;
    public float camMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        boxRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 1)
        {
            boxRenderer.sprite = boxImage;
        }
        if (lives == 0)
        {
            objects[Random.Range(0, objects.Length)].SetActive(true);

            StartCoroutine("destroyGameObject");
        }

    }

    private void OnMouseDown()
    {
        if (gameController.isPaused == false && gameController.isGameOver == false)
        {
            camShake.startCameraShake(camTime, camMagnitude);

            gameController.AudioS.PlayOneShot(punch, punchVolume);
            lives -= 1;
        }
    }

    IEnumerator destroyGameObject()
    {
        yield return new WaitForEndOfFrame();

        Destroy(gameObject);
    }

}
