using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void OpenLevel(int levelId)
    {
        string levelName = "Dinosaur " + levelId;
        SceneManager.LoadScene(levelName);
    }
}
