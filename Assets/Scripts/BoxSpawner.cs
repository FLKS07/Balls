using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnLocation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject child = GameObject.Instantiate(prefab);
        child.transform.position = spawnLocation.position;
    }
}
