using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCurrentSprite : MonoBehaviour, IDataPersistence
{
    public Sprite[] backgroundSprite;
    private SpriteRenderer spriteRenderer;
    public int currentSprite;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void LoadData(GameData data)
    {
        this.currentSprite = data.currentSprite;
    }
    public void Savedata(ref GameData data)
    {
        data.currentSprite = this.currentSprite;
    }

    void Update()
    {
        spriteRenderer.sprite = backgroundSprite[currentSprite];
    }
}
