using UnityEngine;
using System.Collections;

public class PickTable : MonoBehaviour {

    private GameObject[] tables;
    private GameObject pickedTable;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
    {
        tables = GameObject.FindGameObjectsWithTag("Table");
    }
	
	// Update is called once per frame
	void Update ()
    {
        pickedTable = chooseTable(tables);

        print(pickedTable);
	}

    private GameObject chooseTable(GameObject[]tablesArray)
    {
        return tablesArray[Random.Range(0, tablesArray.Length)];
    }
}
