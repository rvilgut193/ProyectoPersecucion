using System;
using UnityEngine;

public class EsferaScript : MonoBehaviour
{
    float radio = 2f;
    float velocidad = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        for (int i = 0; i < 360; i++)
        {
            float angulo = i/ Mathf.PI;
            float x = radio * Mathf.Cos(angulo);
            float z = radio * Mathf.Sin(angulo);
            transform.position += new Vector3(x, 0, z) * Time.deltaTime * velocidad;
        }

    }
}
