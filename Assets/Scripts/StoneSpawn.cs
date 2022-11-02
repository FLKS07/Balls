using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawn : MonoBehaviour
{
    [Header("SpawnTimings")]
    [SerializeField] float spawnTime1;
    [SerializeField] float spawnTime2;
    [SerializeField] float spawnTime3;
    
    float spawnTime;


    [Header("Insticiate info")]
    public GameObject prefab;
    public Transform spawnLocation;

    public float maxX;
    public float minX;

    public int randomSeedNum;

    bool canSpawn;
    [SerializeField]float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
        spawnTime = 20f;
    }

    // Update is called once per frame
    void Update()
    {

        spawnTimings();

        if (canSpawn == true)
        {
            var seed = (int)Time.realtimeSinceStartup;
            Random.InitState(seed * randomSeedNum);
            var randomPos = Random.Range(minX, maxX);

            Vector3 pos = new Vector3(randomPos, spawnLocation.position.y, spawnLocation.position.z);

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

    void spawnTimings()
    {
        elapsedTime += Time.deltaTime;
        

        if (elapsedTime > spawnTime1)
        {
            spawnTime = 15f;
        }
        if (elapsedTime > spawnTime2)
        {
            spawnTime = 10f;
        }
        if (elapsedTime > spawnTime3)
        {
            spawnTime = 5f;
        }
    }


}
