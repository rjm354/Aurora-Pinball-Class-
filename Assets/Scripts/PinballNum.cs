using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinballNum : MonoBehaviour
{

	void Start()
    {
        this.GetComponent<Text>().text = "Pinball: " + Main.pinballn.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
