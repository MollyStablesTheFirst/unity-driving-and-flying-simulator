using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCam;
    public Camera frontCam;
    public Camera player2mainCam;
    public Camera player2frontCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        mainCam.gameObject.SetActive(true);
        frontCam.gameObject.SetActive(false);
        player2mainCam.gameObject.SetActive(true);
        player2frontCam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCam.gameObject.SetActive(!mainCam.gameObject.activeSelf);
            frontCam.gameObject.SetActive(!frontCam.gameObject.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            player2mainCam.gameObject.SetActive(!player2mainCam.gameObject.activeSelf);
            player2frontCam.gameObject.SetActive(!player2frontCam.gameObject.activeSelf);
        }
    }
}
