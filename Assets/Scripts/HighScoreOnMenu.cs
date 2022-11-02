using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreOnMenu : MonoBehaviour, IDataPersistence
{
    public int maxPoints;
    public TextMeshProUGUI high;

    // Start is called before the first frame update
    public void LoadData(GameData data)
    {
        this.maxPoints = data.maxPoints;
    }
    public void Savedata(ref GameData data)
    {
        return;
    }

    void Update()
    {
        high.text = maxPoints.ToString();
    }

}
