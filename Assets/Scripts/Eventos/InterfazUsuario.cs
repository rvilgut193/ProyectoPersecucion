using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InterfazUsuario : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textoPuntuacion;

    private void OnEnable()
    {
        //EventoAlQueEscuchar += FuncionRespuesta
        //EventoAlQueDejarEscuchar -= FuncionRespuesta
        CuboAzulSeguimiento.AlCambiarPuntuacion += ActualizarTextoPuntuacion;

    }

    private void OnDisable()
    {
        CuboAzulSeguimiento.AlCambiarPuntuacion -= ActualizarTextoPuntuacion;
    }

    private void ActualizarTextoPuntuacion(int num)
    {
        textoPuntuacion.text = num.ToString();
    }
}
