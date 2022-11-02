using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBtn : MonoBehaviour
{
    public ShopManager shopManager;
    public int skinID;

    public void Click()
    {
        shopManager.currentSprite = skinID;
    }
}