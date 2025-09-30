using UnityEngine;
using UnityEngine.InputSystem;

//using UnityEngine;  Permite usar todo lo que viene con Unity (GameObjects, transform, etc.).
//using UnityEngine.InputSystem; Usa el nuevo sistema de entrada de Unity para leer el teclado (no el sistema viejo de Input.GetKey()).

public class MovimientoPala : MonoBehaviour
{
    public float speed;
    public bool jugadorA;
    void Update()
    {
        Vector3 direccion = new Vector3(0, 0, 0);

        if (jugadorA)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                direccion.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                direccion.y = -1;
            }
            if (Keyboard.current.aKey.isPressed)
            {
                direccion.x = -1;
            }
            if (Keyboard.current.dKey.isPressed)
            {
                direccion.x = 1;
            }
        }
        else
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                direccion.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                direccion.y = -1;
            }
            if (Keyboard.current.leftArrowKey.isPressed)
            {
                direccion.x = -1;
            }
            if (Keyboard.current.rightArrowKey.isPressed)
            {
                direccion.x = 1;
            }
        }



        transform.position = transform.position + direccion * speed * Time.deltaTime;
    }
}
