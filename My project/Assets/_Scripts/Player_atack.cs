using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player_atack : MonoBehaviour
{
    public float bounceForce;

    private Rigidbody2D _rb;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            _rb.AddForce(transform.up * bounceForce, ForceMode2D.Impulse);
            collision.GetComponent<EnemyMovement>().canMove = false;
            Destroy(collision.gameObject, 0.5f);
        }
    }

}
