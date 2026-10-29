using UnityEngine;

public class EjercicioBucle1 : MonoBehaviour
{
    GameObject cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i =0; i<10;i++)
        {
        cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(i*1.2f, 0.5f, 0);
            if (i%2 == 0)
            {
                cubo.transform.GetComponent<Renderer>().material.color = Color.blue;
            }else{
                cubo.transform.GetComponent<Renderer>().material.color = Color.red;
            }


            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
