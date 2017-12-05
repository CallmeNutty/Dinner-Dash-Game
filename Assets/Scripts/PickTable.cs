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


    //Co routine for spawning costumers
    private IEnumerator SpawnCustomer(int interval, GameObject customer)
    {
        if (pickedTable.transform.childCount < 1) //If customer already exists here
        {
            Instantiate(customer, new Vector3(pickedTable.transform.position.x, pickedTable.transform.position.y - 1), Quaternion.identity, pickedTable.transform); //Spawn customer
        }

        yield return new WaitForSeconds(interval); //Wait for "Interval" seconds

    }

    // Use this for initialization
    void Start ()
    {
        //Populate tables array with Objects of tag "Table"
        tables = GameObject.FindGameObjectsWithTag("Table");
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Pick a random table from the "tables" array
        pickedTable = chooseTable(tables);

        //Begin co routine to spawn customers
        StartCoroutine(SpawnCustomer(spawnInterval, customer));
	}


    //Choosees table by picking random value inside array
    private GameObject chooseTable(GameObject[]tablesArray)
    {
        return tablesArray[Random.Range(0, tablesArray.Length)];
    }
}
