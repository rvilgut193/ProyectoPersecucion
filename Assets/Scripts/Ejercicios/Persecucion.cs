using UnityEngine;

public class Persecucion : MonoBehaviour
{
    [SerializeField] private Transform CuboRojo;
    [SerializeField] float velocidad;
    [SerializeField] private float distannciaSeguimiento = 10f;
    [SerializeField] private float distannciaEvasion = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = CuboRojo.position - transform.position;
        
        if (direccion.magnitude < distannciaEvasion){
            transform.position += -direccion * velocidad * Time.deltaTime;
        }else if (direccion.magnitude < distannciaSeguimiento)
        {
        transform.position += direccion * velocidad * Time.deltaTime;
        }
    }
}
