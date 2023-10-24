using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.W))
            playerRigidbody.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            playerRigidbody.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            playerRigidbody.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            playerRigidbody.MovePosition(transform.position + Vector3.back * speed * Time.deltaTime);


    }
}
