
using UnityEngine;

public class Coin_Animation : MonoBehaviour
{

    public Animator _anim;


    // Update is called once per frame
    void Update()
    {
        CoinAnim();
    }

    public void CoinAnim()
    {
        if(Input.GetKeyDown(KeyCode.R))
        _anim.SetTrigger("Moverse");
    }
}
