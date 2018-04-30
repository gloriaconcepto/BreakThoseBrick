using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public GameObject quitButton;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Basic function for loading level
    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }
    public void RestartAScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
    public void QuitGame()
    {
        if (Application.isEditor)
        {
            Debug.Log("Attempted to quit from the Editor.");
        }
        else if (Application.isWebPlayer)
        {
            quitButton = GameObject.FindGameObjectWithTag("Quit");
            quitButton.SetActive(false);
            Debug.Log("Attempted to quit from the Web Player.");
        }
        else if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            quitButton = GameObject.FindGameObjectWithTag("Quit");
            quitButton.SetActive(false);
            Debug.Log("Attempted to quit from the WebGL Player.");
        }
        else
        {
            Application.Quit();
        }
    }
}

