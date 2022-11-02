using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxFall : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxVelocity;
    private Rigidbody2D rb2d;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = Vector3.ClampMagnitude(rb2d.velocity, maxVelocity);
    }
}
