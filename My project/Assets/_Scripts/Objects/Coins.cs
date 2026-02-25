using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coins : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats.score += coinValue;
            Debug.Log(PlayerStats.score);
            Destroy(gameObject);
        }       
    }
}
