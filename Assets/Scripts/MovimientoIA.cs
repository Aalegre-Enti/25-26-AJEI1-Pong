using Unity.VisualScripting;
using UnityEngine;

//using UnityEngine;  Permite usar todo lo que viene con Unity (GameObjects, transform, etc.).
//using UnityEngine.InputSystem; Usa el nuevo sistema de entrada de Unity para leer el teclado (no el sistema viejo de Input.GetKey()).

public class MovimientoIA : MonoBehaviour
{
    public float speed;

    public GameObject pelota;

    void Update()
    {
        Vector3 direccion = new Vector3(0, 0, 0);

        if (pelota.transform.position.y < transform.position.y)
        {
            direccion.y = -1;
        }
        else
        {
            direccion.y = +1;
        }

        transform.position = transform.position + direccion * speed * Time.deltaTime;
    }
}
