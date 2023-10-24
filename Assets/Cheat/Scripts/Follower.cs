using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject objectToFollow;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - objectToFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + objectToFollow.transform.position;
    }
}
