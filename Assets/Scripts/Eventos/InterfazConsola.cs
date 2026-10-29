using UnityEngine;

public class InterfazConsola : MonoBehaviour
{

    //Escucha al evento AlEntrarEnAreaMin
    //Responde mostrando la posicion a la que se ha movido al cubo perseguidor por consola

    private void OnEnable()
    {
        //EventoAlQueEscuchar += FuncionRespuesta
        //EventoAlQueDejarEscuchar -= FuncionRespuesta
        CuboAzulSeguimiento.AlEntrarEnAreaMin += ImprimirPosicionCubo;

    }

    private void OnDisable()
    {
        CuboAzulSeguimiento.AlEntrarEnAreaMin -= ImprimirPosicionCubo;
    }

    public void ImprimirPosicionCubo(Vector3 p)
    {
        Debug.Log(p);
    }

}
