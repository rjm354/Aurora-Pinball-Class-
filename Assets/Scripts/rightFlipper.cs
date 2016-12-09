using UnityEngine;
using System.Collections;

public class rightFlipper : MonoBehaviour
{
    public static bool active = false;
    private float duration = 0.2f;
    private float timeStart;
    private float rotationSpeed = 125.0f;

    void Awake()
    {

    }

    //Use this for initialization
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        if(active == true)
        {
            Rotate();
        }
        else if ((Input.GetAxis("Horizontal") == 1) && (active == false))
        {
            active = true;
            timeStart = Time.time;
            Rotate();
        }
    }

    void Rotate()
    {
        float u = (Time.time - timeStart) / duration;
        //print out the remainder of the rotation duration
        //print(duration);
        if(u >= 1)
        {
            active = false;
            transform.rotation = Quaternion.Euler(180, 0, 340);
        }
        else if(u >= 0.5)
        {
            float rotation = rotationSpeed * Time.deltaTime;
            transform.Rotate(rotation, rotation * (-3f), 0, Space.World);
        }
        else
        {
            float rotation = rotationSpeed * Time.deltaTime;
            transform.Rotate(-rotation, rotation * (3f), 0, Space.World);
        }
        
    }
}
