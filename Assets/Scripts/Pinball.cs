using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pinball : MonoBehaviour {

    public GameObject other;
    public GameObject pinball;
    public bool _________________;
    public Bounds bounds;
    // Use this for initialization
    void Start ()
    {
        
	}
	
    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter(Collision coll)
    {

        GameObject other = coll.gameObject;
        //If the collider with the Pinball GameObject has one of these tags, add its score to the
        //overall score.

        if(other.tag == "bounceTrigger")
        {
            Main.addScore(bounceTrigger.score);
        }
        if(other.tag == "bounceTriggerStrong")
        {
            Main.addScore(bounceTriggerStrong.score);
        }
    }

	void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (other.tag == "plunger")
        {
            //print("You have collided with the Plunger object.");
            //The Pinball must be launched parallel to the board's orientation. The velocities must be
            //added in the right proportions.

            //Pinball velocities originating from the plunger are chosen at random. A random number from 0-10 is
            //added to initial x velocity 26. The y velocity corresponds to the x velocity to factor in for the slope.
            float xVel = Random.Range(0, 10);
            xVel += 26f;
            rb.velocity = new Vector3(xVel, xVel / 4.5f, 0.0f);
        }
        if(other.tag == "endBoard")
        {
            //Test print statement declaring if the Pinball has touched endBoard object.
            //print("You have touched the endBoard object.");
            Main.newCredits();
            Destroy(this.gameObject);
            Main.spawnPinball(pinball);
        }
    }
}
