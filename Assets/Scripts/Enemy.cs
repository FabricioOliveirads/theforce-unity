using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private Transform backPoint;
    private Animator animator;
    private Rigidbody2D rig;
    public float minSpeed;
    public float maxSpeed;

     void Start()
    {
        backPoint = GameObject.Find("BackPoint").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.left * Speed * Time.deltaTime);
        rig.velocity = new Vector2(Random.Range(minSpeed,maxSpeed)*-1, rig.velocity.y);
        if(transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag =="Bullet")
        {
            animator.SetTrigger("destroy");
            Destroy(gameObject,1f);
        } 
    }
}
