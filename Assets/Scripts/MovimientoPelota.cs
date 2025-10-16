using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed;
    //Para comunicar dos scripts entre sí, el que se quiera comunicar necesita una
    //variable publica para guardar un "acceso directo" al script externo
    public GameManager manager;
    Vector3 direccion;
    void Start()
    {
        Spawn();
    }

    void Update()
    {
        transform.position = transform.position + direccion * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Vertical"))
        {
            direccion.x = direccion.x * -1;
        }
        if (collision.CompareTag("Horizontal"))
        {
            direccion.y = direccion.y * -1;
        }
        if (collision.name == "PorteriaA")
        {
            Debug.Log("Jugador B ha marcado");
            manager.puntB = manager.puntB + 1;
            Spawn();
        }
        if (collision.name == "PorteriaB")
        {
            Debug.Log("Jugador A ha marcado");
            manager.puntA = manager.puntA + 1;
            Spawn();
        }
    }

    void Spawn()
    {
        transform.position = new Vector3(0, 0, 0);
        direccion = new Vector3(
               Random.Range(-1.0f, 1.0f),
               Random.Range(-1.0f, 1.0f),
               0);

        if (direccion.x > 0)
        {
            direccion.x = 1;
        }
        else
        {
            direccion.x = -1;
        }
    }
}
