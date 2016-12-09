using UnityEngine;
using System.Collections;

public class bounceTrigger : MonoBehaviour
{
    static public bounceTrigger S;
    public Color originalColor;
    public GameObject gameObjectToChange;
    private int showForFrames = 20;
    private int remainingForFrames = 0;
    public static int score = 200;

    void Awake()
    {
        S = this;
        //Test code to check the name of this gameObject
        //print(S.ToString());
        if(S.ToString() == "bounceMushroom (bounceTrigger)")
        {
            gameObjectToChange = S.transform.Find("light").gameObject;
            //print(gameObjectToChange.ToString());
            originalColor = gameObjectToChange.GetComponent<Renderer>().sharedMaterial.color;
            //print(gameObjectToChange.GetComponent<Renderer>().sharedMaterial.ToString());
        }
        else
        {
            gameObjectToChange = S.gameObject;
        }
    }


	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(remainingForFrames > 0)
        {
            remainingForFrames--;
            if(remainingForFrames == 0)
            {
                unshowChanges();
            }
        }
	}

    void OnCollisionEnter(Collision coll)
    {
        GameObject other = coll.gameObject;
        if(other.tag == "pinball")
        {
            if(gameObjectToChange.ToString() == "light (UnityEngine.GameObject)")
            {
                //print("will be changing material color now");
                showChanges();
            }
            other.GetComponent<Rigidbody>().AddForce(18, 0, 0, ForceMode.VelocityChange);
        }
    }

    void showChanges()
    {
        //This method will make temporary changes to the GameObject's material color
        //to show that some kind of impact has occured.
        gameObjectToChange.GetComponent<Renderer>().material.color = Color.red;
        remainingForFrames = showForFrames;
    }

    void unshowChanges()
    {
        gameObjectToChange.GetComponent<Renderer>().material.color = originalColor;
    }
}
