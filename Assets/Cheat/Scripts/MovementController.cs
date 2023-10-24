using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float speed;

    private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            playerRigidBody.AddForce(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            playerRigidBody.AddForce(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            playerRigidBody.AddForce(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            playerRigidBody.AddForce(Vector3.back * speed * Time.deltaTime);
    }
}
