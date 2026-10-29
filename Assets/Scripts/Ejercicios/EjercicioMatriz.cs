using UnityEngine;

public class EjercicioMatriz : MonoBehaviour
{

    [SerializeField]float ancho;
    [SerializeField]float separacion;
    GameObject[,] matriz = new GameObject[3, 3];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int fila = 0; fila <ancho; fila++)
        {
            for(int columna = 0; columna<ancho; columna++)
            {
                GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                // matriz[fila, columna] = nuevoCubo;
                nuevoCubo.transform.position = new Vector3(fila*separacion, 0.5f, columna*separacion);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
