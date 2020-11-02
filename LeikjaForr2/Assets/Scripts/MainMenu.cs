using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //fall sem spilar leikinn ef ýtt er á play
   public void PlayeGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //fall sem slekkur á leik ef ýtt er á hann.
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
