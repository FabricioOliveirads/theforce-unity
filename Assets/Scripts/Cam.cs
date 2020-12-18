using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float Speed;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.current.playerIsAlive)
        {
            Vector3 newPosition = new Vector3(player.transform.position.x + 7f, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, Speed * Time.deltaTime);
        }
    }
}
