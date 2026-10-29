using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucle2 : MonoBehaviour
{
    [SerializeField]
    private Vector3[] posiciones =
    {
        new Vector3(0, 0.5f, 0),
        new Vector3(4, 0.5f, 0),
        new Vector3(8, 0.5f, 0),
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;
        StartCoroutine(Mover());
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Corrutina
    IEnumerator Mover()
    {
        while (true)
        {
            foreach (Vector3 pos in posiciones)
            {
                transform.position = pos;
                yield return new WaitForSeconds(0f);
            }
        }
    }
}
