using UnityEngine;

public class Funciones : MonoBehaviour
{
    void MetodoCambio(ref float miAn, ref float miAl)
    {
        miAn = 8;
        miAl = 7;
    }

    void Start()
    {
        float miAncho = 5;
        float miAlto = 6;

        Debug.Log("MiAncho: " + miAncho + ", miAlto: " + miAlto);

        MetodoCambio(ref miAncho, ref miAlto);

        Debug.Log("MiAncho: " + miAncho + ", miAlto: " + miAlto);

        // int puntos = 0;
        // string nombre = "";
        // Vector3 pos = Vector3.zero;

        (int puntos,string  nombre,Vector3 pos)=ObtenerDatos();


    }
    
    public (int,string, Vector3) ObtenerDatos()
    {
        // p = 100;
        // n = "Miguel";
        // v = Vector3.one;

        return (100, "Miguel", Vector3.zero);
    }

}
