using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    static List<AsyncOperation> scenes = new List<AsyncOperation>();

    public static void Game_Over()
    {
        scenes.Add(SceneManager.LoadSceneAsync("Game Over"));
    }
}
