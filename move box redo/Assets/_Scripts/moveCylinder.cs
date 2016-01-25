using UnityEngine;
using System.Collections;

public class moveCylinder : MonoBehaviour {

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
        if (Input.GetKey("a"))
        {
            move = true;
        }

        if (move == true && side == false)
        {
            Lerp(-1 * Time.deltaTime * speed, 0, 0);
        }

        if (move == true && side == true)
        {
            Lerp(1 * Time.deltaTime * speed, 0, 0);
        }

        if (gameObject.transform.position.x >= 3.48f)
        {
            move = false;
            side = false;
        }

        if (gameObject.transform.position.x <= -3.65f)
        {
            move = false;
            side = true;
        }
    }
}
