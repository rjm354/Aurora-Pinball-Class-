using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameMenuEvents : MonoBehaviour
{
    public AudioSource aud;
    public GameObject leftFlipper;
    public GameObject rightFlipper;
    public GameObject gameToolbar;
    public GameObject gameMenu;
    public GameObject helpMenuCanvas;
    public GameObject creditsMenuCanvas;
    public GameObject pinball;
    public GameObject dataCanvases;

	public void btnPlayClick()
    {
        aud.Play();
        leftFlipper.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        dataCanvases.SetActive(true);
        gameToolbar.SetActive(true);
        gameMenu.SetActive(false);
        Main.spawnPinball(pinball);
    }
    
    public void btnHelpClick()
    {
        gameMenu.SetActive(false);
    }

    public void btnCreditsClick()
    {
        creditsMenuCanvas.SetActive(true);
        gameMenu.SetActive(false);

    }

    public void btnBackClick()
    {
        //This code makes the back button hide the current option container
        //and makes the Game Menu reappear.
        gameMenu.SetActive(true);
    }
}
