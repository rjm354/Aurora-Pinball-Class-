using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameToolbarEvents : MonoBehaviour
{
    [SerializeField]
    private int scene;

	public void btnExitGameClick()
    {
        SceneManager.LoadSceneAsync("Loading");
    }
}
