using UnityEngine;
using System.Collections;

public class PickTable : MonoBehaviour {

    //Declare Variables
    [SerializeField]
    private int spawnInterval;

    private GameObject[] tables;
    private GameObject pickedTable;
    [SerializeField]
    private GameObject customer;
    private SpriteRenderer spriteRenderer;


    private IEnumerator SpawnCustomer(int interval, GameObject customer)
    {
        if (pickedTable.transform.childCount < 1)
        {
            Instantiate(customer, new Vector3(pickedTable.transform.position.x, pickedTable.transform.position.y - 1), Quaternion.identity, pickedTable.transform);
        }

        yield return new WaitForSeconds(interval);

    }

    // Use this for initialization
    void Start ()
    {
        tables = GameObject.FindGameObjectsWithTag("Table");
    }
	
	// Update is called once per frame
	void Update ()
    {
        pickedTable = chooseTable(tables);

        StartCoroutine(SpawnCustomer(spawnInterval, customer));
	}

    private GameObject chooseTable(GameObject[]tablesArray)
    {
        return tablesArray[Random.Range(0, tablesArray.Length)];
    }
}
