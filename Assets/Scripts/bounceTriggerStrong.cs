using UnityEngine;
using System.Collections;

public class bounceTriggerStrong : MonoBehaviour
{
    public static int score = 500;

    //Use this for initialization
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject other = coll.gameObject;
        if(other.tag == "pinball")
        {
            other.GetComponent<Rigidbody>().AddForce(24, 0, 0, ForceMode.VelocityChange);
        }
    }
	
}
