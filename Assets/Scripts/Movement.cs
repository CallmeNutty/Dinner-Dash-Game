using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    [SerializeField]
    private float speed;
	
	// Update is called once per frame
	void Update ()
    {
        //Forward Movement
	    if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 1 * speed, 0));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //Left Movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, 1 * speed, 0));
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        //Right Movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, 1 * speed, 0));
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }

        //Down Movement
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 1 * speed, 0));
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }
}
