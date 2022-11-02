using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveAdd : MonoBehaviour
{
    public GameController gameController;

    private void OnMouseDown()
    {
        gameController.Lives += 1;
    }
}
