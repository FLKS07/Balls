using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCardBord : MonoBehaviour
{

    public Transform whatToFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(whatToFollow == null)
        {
            return;
        }
        else if(whatToFollow != null)
        {
            transform.position = whatToFollow.position;
        }
        
    }
}
