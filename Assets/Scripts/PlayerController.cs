using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravityMultiplier = 1f;
    private Rigidbody rb;
    private InputAction jumpAction;
    private bool isOnGround;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered && isOnGround == true)
        {
                rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
                isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit" + collision.gameObject.name);
        isOnGround = true;
    }
}
