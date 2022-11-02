using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public DataPersistenceManager dataManager;

    public void changeScne()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);

        if (dataManager != null)
        {
            dataManager.SaveGame();
        }

    }
}
