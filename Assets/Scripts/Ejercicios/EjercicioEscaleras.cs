using UnityEngine;

public class Ejercicioescaleras : MonoBehaviour
{

    [SerializeField]float numeroEscalones;
    [SerializeField]float profundidad;
    [SerializeField] float altura;

    GameObject[,] matriz = new GameObject[3, 3];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i <=numeroEscalones; i++)
        {
            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.localScale = new Vector3(altura,profundidad, 5);
            nuevoCubo.transform.position = new Vector3(i*altura,i*profundidad, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
