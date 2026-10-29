using UnityEngine;

public class CuboScript : MonoBehaviour
{

    [SerializeField] private float velocidad = 5f;
    public void SoyApuntado()
    {
        Debug.Log("Soy el objeto " + transform.name + " y me estan apuntando con un raycast");
    }

    void Update()
    {
        float movimiento = velocidad * Time.deltaTime;

        if (transform.position.x < 10 && transform.position.z <= 0)
        {
            // Derecha
            transform.position += new Vector3(movimiento, 0, 0);
        }
        else if (transform.position.x >= 10 && transform.position.z < 10)
        {
            // Arriba
            transform.position += new Vector3(0, 0, movimiento);
        }
        else if (transform.position.z >= 10 && transform.position.x > 0)
        {
            // Izquierda
            transform.position += new Vector3(-movimiento, 0, 0);
        }
        else if (transform.position.x <= 0 && transform.position.z > 0)
        {
            // Abajo
            transform.position += new Vector3(0, 0, -movimiento);
        }
    }
}
