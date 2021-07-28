using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    
    // Start is called before the first frame update
    List<AsyncOperation> scenes = new List<AsyncOperation>();
    public void StartGame()
    {
        HideMenu();
        scenes.Add(SceneManager.LoadSceneAsync("Game"));
    }

    public void HideMenu()
    {
        menu.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
