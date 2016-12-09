using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{

	void Start()
    {
        this.GetComponent<Text>().text = "Score: " + Main.score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
