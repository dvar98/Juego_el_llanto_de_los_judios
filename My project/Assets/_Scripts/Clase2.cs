using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2 : MonoBehaviour
{

    public GameObject Hexagon;

    private Vector3 location;

    // Start is called before the first frame update
    void Start()
    {
        TP();

    }

    public void TP()
    {
        location = transform.position = Hexagon.transform.position;

        Debug.Log("La ubicacion del Hexagono es: " + location + " su color es: rojo");
    }



}
