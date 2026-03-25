using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayeShoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform FireHost;


    public void shoot(InputAction.CallbackContext context)
    {

        if(context.started)
        {
            GameObject bullet = Instantiate(bulletPrefab, FireHost.position, FireHost.rotation);
            Destroy(bullet,1);
        }
    }
}
