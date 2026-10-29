using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private InputSystem_Actions input;
    [SerializeField] private float velocidad = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        input = new InputSystem_Actions();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = input.Player.Move.ReadValue<Vector2>();

        Vector3 direccion = new Vector3(movimiento.x, 0, movimiento.y);

        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}
