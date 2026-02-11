using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Excercise : MonoBehaviour
{
    //Variables
    [Header("Numbers")]
    public int a;
    public int b;
    private int _result;


    // Start is called before the first frame update
    void Start()
    {
        AddNumber();
    }

    //Suma
    public void AddNumber()
    {
        _result = a+b;
        Debug.Log("El resultado es: " + _result);
        Debug.Log(string.Format("El resultado es: {0}", _result ));
    }
}
