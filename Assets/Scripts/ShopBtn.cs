using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBtn : MonoBehaviour
{
    public ShopManager shopManager;
    public int skinID;
    public AudioClip buttonSfx;

    public void Click()
    {
        shopManager.PlaySFX(buttonSfx);
        shopManager.changeSprite(skinID);
    }
}