using UnityEngine;
using System.Collections;

public class flipperTop : MonoBehaviour
{

	public void OnCollisionEnter(Collision coll)
    {
        GameObject other = coll.gameObject;
        if((other.tag == "pinball") && ((leftFlipper.active == true) || (rightFlipper.active == true)))
        {
            other.GetComponent<Rigidbody>().AddForce(21, 0, 0, ForceMode.VelocityChange);
        }
    }
}
