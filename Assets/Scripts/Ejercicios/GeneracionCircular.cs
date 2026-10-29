using System.Collections.Generic;
using UnityEngine;

public class GeneracionCircular : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // float anguloActual = 0;
        // float angulo30grados = Mathf.PI / 6;
        // float radio = 10f;
        // float x, z;
        // List<GameObject> cubos = new List<GameObject>();



        // for (int i = 0; i <= 2000; i++)
        // {
        //     x = Mathf.Cos(anguloActual) * i / radio;
        //     z = Mathf.Sin(anguloActual) * i / radio;

        //     GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //     nuevoCubo.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        //     nuevoCubo.transform.position = new Vector3(x, i, z);
        //     nuevoCubo.GetComponent<Renderer>().material.color = Color.red;
        //     cubos.Add(nuevoCubo);
        //     anguloActual = anguloActual + angulo30grados;
        // }





        int i = 0;
        float objetosPorVuelta = 100f;
        float vueltas = 50;
        float radio = 0.5f;
        float indiceSubida = 0.1f;

        do
        {
            float angulo = (Mathf.PI * 2 * i) / objetosPorVuelta;

            float x = radio * Mathf.Cos(angulo);
            float z = radio * Mathf.Sin(angulo);
            float y = i * indiceSubida;

            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            nuevoCubo.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            radio = radio + 0.05f;
            nuevoCubo.transform.position = new Vector3(x, y, z);
            i++;
        } while (i < vueltas * objetosPorVuelta);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
