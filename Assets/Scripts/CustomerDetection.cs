using UnityEngine;
using System.Collections;

public class CustomerDetection : MonoBehaviour
{

    [SerializeField]
    private Canvas speechBubble;
    [SerializeField]
    private AudioClip blip;

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
        if (Input.GetKeyDown(KeyCode.Space) && speechBubble.gameObject.activeInHierarchy)
        {
            AudioSource.PlayClipAtPoint(blip, new Vector3(0, 0, 0));
        }
	}
}
