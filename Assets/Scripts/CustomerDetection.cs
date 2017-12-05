using UnityEngine;
using System.Collections;

public class CustomerDetection : MonoBehaviour
{

    [SerializeField]
    private Canvas speechBubble;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        speechBubble.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        speechBubble.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
