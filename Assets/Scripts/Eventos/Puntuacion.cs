using UnityEngine;

public class Puntuacion : MonoBehaviour
{

    public delegate void MiDelegado(int nuevaPuntuacion);
    public static event MiDelegado AlCambiarPuntuacion;
    private int puntuacion = 0;

    public void AumentarPuntuacion(int cantidad)
    {
        puntuacion += cantidad;

        // Para que otras clases reaccionen a este cambio

        AlCambiarPuntuacion?.Invoke(puntuacion);
    }


}
