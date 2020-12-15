using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneretion : MonoBehaviour
{
    public GameObject Platform;
    public Transform point;
    public float Distance;
    private float plaftormWidth;
    void Start()
    {
        if (Platform.GetComponent<BoxCollider2D>())
        {
            plaftormWidth = Platform.GetComponent<BoxCollider2D>().size.x;
        }
        else
        {
            plaftormWidth = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;
        }
    }

    
    void Update()
    {
        if(transform.position.x < point.position.x)
        {
           // Distance = Random.Range(3f,8f);
            transform.position = new Vector3(transform.position.x + plaftormWidth + Distance, transform.position.y, transform.position.z);
            Instantiate(Platform, transform.position, transform.rotation);
        }
    }
}
