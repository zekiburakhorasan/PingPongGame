using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
	public void GoScene (string SceneName)
    {
        SceneManager.LoadScene(SceneName);  //ilgili sahneyi yükler
	}

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
