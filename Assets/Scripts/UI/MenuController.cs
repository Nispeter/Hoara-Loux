using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Debug.Log("Game closed");
        Application.Quit();
    }

    public void GoMenu(){
        SceneManager.LoadScene(0);
    }

    public virtual void RetryGame(){}
}
