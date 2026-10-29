using UnityEngine;

public class EjercicioPiramide : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float ancho = 5;
        float separacion = 1.1f;

        for (float i = 0; i <= 5; i++)
        {
            for (int fila = 0; fila < ancho; fila++)
            {
                for (int columna = 0; columna < ancho; columna++)
                {
                    GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    nuevoCubo.transform.position = new Vector3(fila * separacion, 1.1f * i, columna * separacion);
                }
            }
            ancho--;
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
