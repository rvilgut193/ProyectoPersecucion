using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CuboAzulSeguimiento : MonoBehaviour
{

    public delegate void MiDelegado(int p);
    public static event MiDelegado AlCambiarPuntuacion;
    public delegate void MiDelegado2(Vector3 p);
    public static event MiDelegado2 AlEntrarEnAreaMin;

    int puntuacion = 0;
    [SerializeField] private GameObject objetivo;

    [SerializeField] private float distanciaSeguimiento = 150f;
    [SerializeField] private float distanciaMin = 3f;

    [SerializeField] private float velocidad = 5f;

    // int spawn = 1;
    // Vector3 posicionSpawn;

    [SerializeField]private List<Vector3> listaPosiciones;
    int i = -1;

    // Update is called once per frame
    void Update()
    {
        float distanciaObetivo = Vector3.Distance(objetivo.transform.position, transform.position);

        Vector3 direccion = (objetivo.transform.position - transform.position).normalized;

        if (distanciaObetivo < distanciaMin)
        {
            AumentarPuntuacion(); //Sumo puntuacion en ele script principal
            AlCambiarPuntuacion?.Invoke(puntuacion);// Notifico al resto de scripts para que reaccionen al cambio, recibiendo la puntuacion
            // switch (spawn)
            // {
            //     case 1: posicionSpawn = new Vector3(0, 0, 0); break;
            //     case 2: posicionSpawn = new Vector3(10, 0, 0); break;
            //     case 3: posicionSpawn = new Vector3(0, 0, 10); break;
            //     case 4: posicionSpawn = new Vector3(10, 0, 10); break;
            // }
            // transform.position = posicionSpawn;
            // if (spawn < 4)
            // {
            //     spawn++;
            // }
            // else
            // {
            //     spawn = 1;
            // }
            ModificarPosicion();
            AlEntrarEnAreaMin?.Invoke(transform.position);
        }
        else if (distanciaObetivo < distanciaSeguimiento)
        {
            transform.position += direccion * velocidad * Time.deltaTime;
        }



    }

    private void ModificarPosicion()
    {
        i++;
        i = i % 4;
        transform.position = listaPosiciones[i];
    }
    public void AumentarPuntuacion()
    {
        puntuacion++;
    }
}
