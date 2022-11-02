using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMeBehaviour : MonoBehaviour
{
    public Transform objectToFolowMe;

    void Update()
    {
        objectToFolowMe.position = transform.position;
    }
}
