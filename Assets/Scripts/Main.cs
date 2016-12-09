using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Main : MonoBehaviour
{
    public AudioSource aud;
    public AudioClip audNew;
    private static bool creditSet;
    public GameObject dataCanvases;
    public GameObject gameToolbar;
    public GameObject menuButtonDescs;
    public GameObject bounceWall;
    public Text creditsLeft;
    public Text pinballNum;
    public Text Score;
    public int creditsSet = 1000;
    public static int credits = 1000;
    public static int pinballn;
    public static int pinballMultiplier = 1;
    public static int score;

    public bool _____________________;

    void Awake()
    {
        credits = creditsSet;
        pinballn = 0;
        score = 0;
        dataCanvases.SetActive(false);
        gameToolbar.SetActive(false);
        menuButtonDescs.SetActive(false);
    }

	// Use this for initialization
	void Start ()
    {
        
	}
	// Update is called once per frame
	void Update () {
	    if(aud.time == 366)
        {
            //aud.mute = true;
            aud.clip = audNew;
            aud.Play();
            aud.loop = true;
        }
        if(creditSet == true)
        {
            pinballn++;
            setCredits();
            creditSet = false;
        }
        setScore();
	}
    public static void addScore(int scoreToAdd)
    {
        score += (scoreToAdd * pinballMultiplier);
    }

    public static void spawnPinball(GameObject Pinball)
    {
        GameObject ball = Instantiate(Pinball) as GameObject;
        Vector3 pos = new Vector3(-2.8f, -0.8f, -4.2f);
        ball.transform.position = pos;
    }
    public static void newCredits()
    {
        credits = credits - (100 *pinballMultiplier);
        creditSet = true;

    }
    public void setCredits()
    {
        //In this method the value of Text pinballNum will change
        //Pinball number (used pinballs) increases with these deduction of credits.
        pinballNum.text = "Pinball: " + pinballn.ToString();
        creditsLeft.text = "Credits: " + credits.ToString();
        if(credits <= 0)
        {
            credits = creditsSet;
            pinballn = 0;
            score = 0;
            SceneManager.LoadSceneAsync("Loading");
        }
    }
    public void setScore()
    {
        Score.text = "Score: " + score.ToString();
    }
}
