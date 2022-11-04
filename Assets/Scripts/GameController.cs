using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour, IDataPersistence
{


    [Header("Lives")]
    public int Lives;
    public GameObject[] LivesSprites;
    public GameObject gameOverPanel;
    public GameObject pauseButton;

    public bool isGameOver;
    public AudioClip gameOverSound;
    bool gameOverSoundPlayed;


    [Header("Points")]
    public int Points;
    public TextMeshProUGUI PointsTxt;

    public int maxPoints;
    public TextMeshProUGUI maxPointsText;

    [Header("Coins")]
    public int Coins;
    public TextMeshProUGUI textCoins;


    [Header("Sfx")]
    public AudioSource AudioS;

    [Header("Pause")]
    public bool isPaused;

    [Header("Background")]
    public SpriteRenderer backgroundSpriteRenderer;
    [SerializeField] int currentBackgroundSprite;
    public Sprite[] backgroundSprites;
    public Background backgroundShader;


    public void LoadData(GameData data)
    {
        this.maxPoints = data.maxPoints;
        this.currentBackgroundSprite = data.currentSprite;
    }
    public void Savedata(ref GameData data)
    {
        data.maxPoints = this.maxPoints;
        data.coins = data.coins + Coins;
    }



    // Start is called before the first frame update
    void Start()
    {
        AudioS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        PointsTxt.text = Points.ToString();

        if (maxPoints <= Points)
        {
            maxPoints = Points;
        }

        backgroundSpriteRenderer.sprite = backgroundSprites[currentBackgroundSprite];
        if (currentBackgroundSprite == 1)
        {
            backgroundShader.movmentSpeed = new Vector2(0, 0);
        }
        //Show high Score
        maxPointsText.text = "Best score off al time: " + maxPoints;
        //Show coin ammount
        textCoins.text = Coins.ToString();


        //Update Lives

        if (Lives >= 3)
        {
            Lives = 3;
        }

        if (Points < 0)
        {
            Points = 0;
        }


        if (Lives <= 0)
        {
            LivesSprites[0].SetActive(false);
            LivesSprites[1].SetActive(false);
            LivesSprites[2].SetActive(false);

            gameOverPanel.SetActive(true);
            pauseButton.SetActive(false);

            Time.timeScale = 0f;
            isGameOver = true;

            if (gameOverSoundPlayed == false)
            {
                AudioS.Stop();
                AudioS.PlayOneShot(gameOverSound);
                gameOverSoundPlayed = true;
            }
            else if (gameOverSoundPlayed == true)
            {
                return;
            }

            AudioS.PlayOneShot(gameOverSound);
        }

        else if (Lives == 1)
        {
            LivesSprites[0].SetActive(true);
            LivesSprites[1].SetActive(false);
            LivesSprites[2].SetActive(false);
        }
        else if (Lives == 2)
        {
            LivesSprites[0].SetActive(true);
            LivesSprites[1].SetActive(true);
            LivesSprites[2].SetActive(false);
        }
        else if (Lives == 3)
        {
            LivesSprites[0].SetActive(true);
            LivesSprites[1].SetActive(true);
            LivesSprites[2].SetActive(true);
        }
    }
}
