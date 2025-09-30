using UnityEngine;

public class LimitesMovimiento : MonoBehaviour
{
    public float limiteYpos;
    public float limiteYneg;
    public float limiteXpos;
    public float limiteXneg;

    // float -> Decimal
    // int -> Entero
    // Vector3 -> 3 Decimales
    // bool -> verdadero/falso
    // string -> cadena de caracteres

    void Update()
    {
        if (transform.position.y > limiteYpos)
        {
            transform.position = new Vector3(transform.position.x, limiteYpos, 0);
        }
        if (transform.position.y < limiteYneg)
        {
            transform.position = new Vector3(transform.position.x, limiteYneg, 0);
        }
        if (transform.position.x > limiteXpos)
        {
            transform.position = new Vector3(limiteXpos, transform.position.y, 0);
        }
        if (transform.position.x < limiteXneg)
        {
            transform.position = new Vector3(limiteXneg, transform.position.y, 0);
        }
    }
}
