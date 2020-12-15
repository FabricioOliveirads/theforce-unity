using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Transform backPoint;
    void Start()
    {
        backPoint = GameObject.Find("BackPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
    }
}
