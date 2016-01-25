using UnityEngine;
using System.Collections;

public class moveBox : MonoBehaviour {

    public float speed;
    public bool move, side = false;

    void Start ()
    {
        
	}
	
    void Lerp(float a, float b, float c)
    {
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y + b, transform.position.z + c);
    }

	void Update ()
    {
        if (Input.GetKey("w"))
        {
            move = true;
        }

        if (move == true && side == false)
        {
            Lerp(0, 0, 1 * Time.deltaTime * speed);
        }

        if (move == true && side == true)
        {
            Lerp(0, 0, -1 * Time.deltaTime * speed);
        }

        if (gameObject.transform.position.z <= -14)
        {
            move = false;
            side = false;
        }

        if (gameObject.transform.position.z >= -6)
        {
            move = false;
            side = true;
        }
    }
}
