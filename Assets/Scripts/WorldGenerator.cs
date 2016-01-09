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
        if (Input.GetKeyUp(KeyCode.A)) {GenerateWorld (); }
	
	}

    void GenerateWorld ()
    {
        Vector3 playerPos = GameObject.Find("Player").transform.position;
        float RoomScale = 1.0f;
        float Floorheight = 3 * RoomScale;
        float Floorwidth = 5 * RoomScale;
        int currentfloor = (int)(playerPos.x / Floorheight);
        float WallOffsetX = Floorwidth / 2;
        float CeilingOffsetY = Floorheight / 2;
        for (int i = -5; i < 4; i++)
        {
            int hausbreite = 5;
            for (int j = -hausbreite; j < hausbreite; j++)
            {
                // WallGenerator

                float Randomvalue = Random.value;
                if (Randomvalue < 0.6) // NO Wall
                { }
                else
                {
                    GameObject localWallVariation;
                    if (Randomvalue < 0.8) // Solid Wall
                    {
                        localWallVariation = WallVariations[0];
                    }
                    else// Door           
                    {
                        localWallVariation = WallVariations[1];
                    }
                    GameObject LocalGameObject = (GameObject)GameObject.Instantiate(localWallVariation, new Vector3(j * Floorwidth + WallOffsetX, i * Floorheight, 0), Quaternion.identity);
                    //LocalGameObject.transform.localScale = new Vector3(RoomScale, RoomScale, RoomScale);
                }
                if ((j == -hausbreite) || (j == hausbreite - 1)) {
                GameObject LocalGameObject = (GameObject)GameObject.Instantiate(WallVariations[0], new Vector3(j * Floorwidth + WallOffsetX, i * Floorheight, 0), Quaternion.identity);
            }

                Randomvalue = Random.value;

                if (j == -hausbreite) // NO Ceiling
                { }
                else
                {
                    GameObject localCeilingVariation;
                    if (Randomvalue < 0.8) // Solid Ceiling
                    {
                        localCeilingVariation = CeilingVariations[0];
                    }
                    else if (Randomvalue < 0.9) // Hole Ceiling
                    {
                        localCeilingVariation = CeilingVariations[1];
                    }
                    else if (Randomvalue < 0.95) // Stairsright Ceiling
                    {
                        localCeilingVariation = CeilingVariations[2];
                    }
                    else// Stairsleft Ceiling
                    {
                        localCeilingVariation = CeilingVariations[3];
                    }
                    GameObject LocalGameObject = (GameObject)GameObject.Instantiate(localCeilingVariation, new Vector3(j * Floorwidth, i * Floorheight + CeilingOffsetY, 0), Quaternion.identity);
                    //LocalGameObject.transform.localScale = new Vector3(RoomScale, RoomScale, RoomScale);
                }
            }
        }
    }
}
