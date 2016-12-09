using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuEvents : MonoBehaviour {

	public void KoalaButtonClick()
    {
        //AsyncOperation async = 
        SceneManager.LoadSceneAsync("Game");
        //Debug.Log("Koala was clicked.");
    }
    public void KoalaButtonOver()
    {
        Debug.Log("Koala was moused over.");
    }
}
