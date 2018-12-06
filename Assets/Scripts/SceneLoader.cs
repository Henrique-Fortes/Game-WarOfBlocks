using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour {

    public void  LoadNextScene()
    {
        //Carrega as próximas cenas
        int currenteSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currenteSceneIndex + 1);
    }

    public void LoadStartScene()
    {       
        //Carrega a cena de começo do jogo "StartScene"
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
