using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rig;
    public float JumpForce;
    private bool isJumping;
    public GameObject bullet;
    public GameObject smoke;
    public Transform firePoint;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.velocity = new Vector2(Speed * Time.deltaTime, rig.velocity.y);
        if (Input.GetKey(KeyCode.Space)&&!isJumping){
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJumping = true;
            smoke.SetActive(true);
        }
        if(Input.GetKey(KeyCode.Z))
        {
            Instantiate(bullet,firePoint.transform.position,firePoint.transform.rotation);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            smoke.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GameController.current.AddScore(5);
            Destroy(collision.gameObject);
        }
    }
}
