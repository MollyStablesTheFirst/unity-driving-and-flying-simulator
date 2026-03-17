using UnityEngine;

public class FrontViewCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, 1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + player.transform.rotation * offset;
        //Rotating the camera
        transform.rotation = player.transform.rotation;
        transform.Rotate(15f, 0f, 0f);
        //This is one is supossed to be better for cameras because it is not influanced by outside forces that rotate the car
        //transform.rotation = Quaternion.Euler(15f,player.transform.eulerAngles.y,0f);
        //Changes the angle
        //transform.LookAt(player.transform);
    }
}
