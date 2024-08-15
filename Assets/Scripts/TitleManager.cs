using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawnDestination = 0;
    public float tileLength = 100;
    public Transform playerTransform;
    public int numberTile;
    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < numberTile; i++)
        {
            if(i== 0)
            {
                SpawnTile(0);
            }
            else
            {
                SpawnTile(Random.Range(0, tilePrefabs.Length));
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > zSpawnDestination-(numberTile*tileLength)) {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }
    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex],transform.forward*zSpawnDestination,transform.rotation);
        zSpawnDestination+=tileLength;
    }
}
