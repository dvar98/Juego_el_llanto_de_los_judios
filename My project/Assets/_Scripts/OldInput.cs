using UnityEngine;

public class OldInput : MonoBehaviour
{

    // Se declaran las variables
    [HideInInspector] public float horizontal;

    // Se llama cada frame
    void Update()
    {
        // Se llama los metodos para que funcione

        GetInputFloat();
        GetInputButton();
    }


    // Metodo para visibilizar el vector 2
    public void GetInputFloat()
    {
        // Se almacena el eje raw (-1, 0, -1) del eje horizontal (ver Unity "Axis"), en la variable
        horizontal = Input.GetAxisRaw("Horizontal");

        // Se escribe en consola el resultado
        Debug.Log(horizontal);
    }


    // Metodo para visibilizar la presion de boton
    public void GetInputButton()
    {
        // Si el sistema detecta que se presiona la letra "M"
        if(Input.GetKeyDown(KeyCode.M))
        {
            // Se escribe en consola el textor "Shoot"
            Debug.Log("Shoot");
        }
    }
}
