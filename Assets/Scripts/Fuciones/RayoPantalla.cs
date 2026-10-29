using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;

public class RayoPantalla : MonoBehaviour
{

    [SerializeField]GameObject cubo;
    [SerializeField]GameObject capsula;
    [SerializeField]GameObject esfera;
    void Start()
    {

    }

    float longitudRayo = 100f;

    void Update()
    {

        GetComponent<RectTransform>().position = Mouse.current.position.ReadValue();



        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray rayo = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hitInfo;

            if (Physics.Raycast(rayo, out hitInfo, longitudRayo))
            {
                Debug.Log("Hemos apuntado al GO " + hitInfo.transform.name);

                if (hitInfo.transform.name == "Cube")
                {
                    capsula.transform.position = new Vector3(5, 5, 5);
                    cubo.transform.position = new Vector3(100,100,100);

                }
                else if (hitInfo.transform.name == "Capsule")
                {
                    esfera.transform.position = new Vector3(0, 1, 0);
                    capsula.transform.position = new Vector3(100, 100, 100);
                }
                else if (hitInfo.transform.name == "Sphere")
                {
                    cubo.transform.position = new Vector3(-2, 1, 1);
                    esfera.transform.position = new Vector3(100, 100, 100);
                }

            }
            Debug.DrawRay(rayo.origin, rayo.direction * longitudRayo, Color.red);
        }
    }
}
