using UnityEngine;

public class Coin_Taken : MonoBehaviour
{

    public Animator _coin;
    private bool isTaken = false;


    // Start is called before the first frame update
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _coin.SetBool("Tomado", true);
        }
    }
}

