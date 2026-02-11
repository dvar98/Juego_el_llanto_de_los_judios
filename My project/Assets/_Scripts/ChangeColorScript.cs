using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour
{

    public GameObject triangle;

    private SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        ChangeColor();
        ET();
    }

    public void ChangeColor()
    {
        
        _renderer.color = Color.yellow;


    }

    public void ET()
    {
        transform.position = triangle.transform.position;
    }
}
