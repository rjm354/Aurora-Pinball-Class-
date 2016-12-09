using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class creditsLeft : MonoBehaviour
{
	void Start()
    {
        this.GetComponent<Text>().text = "Credits: " + Main.credits;
	}	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
