using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawn : MonoBehaviour
{
    public GameObject[] obj;
    public int maxObject = 500;
    public float currentObject;
    void Start()
    {
        currentObject = 1;
    }
    void Update()
    {
        currentObject++;
        while(currentObject <= maxObject)
            {
                int ramdomIndex = Random.Range(0, obj.Length);
                Vector3 ramdomSpawnPosition = new Vector3(Random.Range(100, -100), 5, Random.Range(-100,100));
                Instantiate(obj[ramdomIndex], ramdomSpawnPosition, Quaternion.identity);
            }
        
        
    }
}