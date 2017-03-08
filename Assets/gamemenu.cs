using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamemenu : MonoBehaviour {

	// Use this for initialization
	public void gamestart () {
        SceneManager.LoadScene("secne", LoadSceneMode.Additive);

    }
    public void gameover()
    {
        Application.Quit();
    }

}
