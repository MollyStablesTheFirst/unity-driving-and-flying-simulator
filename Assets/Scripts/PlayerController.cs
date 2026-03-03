using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 10.0f;
    private float turnspeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        //Player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Move the vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Turn vehicle
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed* horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
    }
}
