using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCam;
    public Camera frontCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        mainCam.gameObject.SetActive(true);
        frontCam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCam.gameObject.SetActive(!mainCam.gameObject.activeSelf);
            frontCam.gameObject.SetActive(!frontCam.gameObject.activeSelf);
        }
    }
}
