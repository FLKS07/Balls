using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBordBoxSpawner : MonoBehaviour
{
    [SerializeField] float spawnTime;
    [SerializeField] GameObject prefab;
    [SerializeField] Transform spawnPostion;
    bool canSpawn;

    [Header("")]
    [SerializeField] float minX;
    [SerializeField] float maxX;



    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
        spawnTime = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn == true)
        {
            Vector3 pos = new Vector3(spawnPostion.position.x, spawnPostion.position.y, spawnPostion.position.z);

            Instantiate(prefab, pos, transform.rotation, transform);

            canSpawn = false;

            StartCoroutine("spawnTimer");

           
        }

        
    }

    IEnumerator spawnTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        canSpawn = true;
    }
}
