using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    SpriteRenderer Sp;
    Vector2 offset;
    [SerializeField] Vector2 movmentSpeed;
    Material material;



    // Start is called before the first frame update
    void Start()
    {
        
        Sp = GetComponent<SpriteRenderer>();
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = movmentSpeed * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
