using UnityEngine;

public class CapsulaScript : MonoBehaviour
{

    [SerializeField] private float velocidad = 5f;
    private int direccion = 1;
    public void SoyApuntado()
    {
        Debug.Log("Soy el objeto " + transform.name + " y me estan apuntando con un raycast");
    }

    void Update()
    {
        float movimiento = velocidad * Time.deltaTime;


        if (transform.position.y >= 7)
        {
            direccion = -1;
        }
        else if (transform.position.y <= 1)
        {
            direccion = 1;
        }

        transform.position += new Vector3(0, movimiento * direccion, 0);
    }
}

