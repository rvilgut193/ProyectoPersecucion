using UnityEngine;

public class PlayerControllerAnim : MonoBehaviour
{

    private InputSystem_Actions input;
    [SerializeField] private float velocidad = 5f;
    
    void Awake()
    {
        input = new InputSystem_Actions();
    }


    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = input.Player.Move.ReadValue<Vector2>();

        Vector3 direccion = new Vector3(movimiento.x, 0, movimiento.y);

        transform.position += direccion.normalized * velocidad * Time.deltaTime;
        



    }
}
