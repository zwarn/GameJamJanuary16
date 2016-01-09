using UnityEngine;
using System.Collections;

public class WorldGenerator : MonoBehaviour {

    public GameObject[] WallVariations;
    public GameObject[] CeilingVariations;

    // Use this for initialization
    void Start () {
        GenerateWorld();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void GenerateWorld ()
    {
        Vector3 playerPos = GameObject.Find("player").transform.position;
        int Floorheight = 3;
        int currentfloor = (int)(playerPos.x / Floorheight);
        for (int i = -1; i < 1; i++)
        {
            for (int j = -10; i < 11; i++)
            {
                GameObject.Instantiate(WallVariations[1], new Vector3(j*5, i*3, 0), Quaternion.identity);
                Debug.Log("hrello");
            }
        }
    }
}
