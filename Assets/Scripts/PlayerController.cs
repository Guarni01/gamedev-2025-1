using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // metri al sec
    public float turnSpeed = 45.0f; //gradi al sec
    private float horizontalInput;
    private float verticalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        //Read the imputs
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Turn the veicole
        transform.Rotate(Vector3.up , Time.deltaTime * turnSpeed * horizontalInput);

    }
}
