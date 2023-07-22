using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        if (inputX != 0)
        {
            transform.Rotate(Vector3.up * inputX);
        }

        direction = new Vector3(0, 0, inputZ);

        //direction = new Vector3(inputX, 0, inputZ);
        direction = transform.TransformDirection(direction);

        
    }

    private void FixedUpdate()
    {
        //rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        rb.velocity = direction * speed;
    }
}