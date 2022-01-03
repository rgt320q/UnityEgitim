using UnityEngine;

public class CameraMouseLook : MonoBehaviour
{
    public Transform playerBody;

    public float mouseSensitivity = 50f;
    public float MinXRotation, MaxXRotation;

    float xRotation, yRotation;    

    // Update is called once per frame
    void FixedUpdate()
    {
        //It is for the camera following the player object.
        //transform.position+new Vector3(0,0.5f,0) Adds 0.5 to the camera's y-coordinate.
        transform.position = Vector3.Lerp(transform.position+new Vector3(0,0.5f,0), playerBody.position, 0.5f);
    }

    private void LateUpdate()
    {
        xRotation -= Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        yRotation += Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        xRotation = Mathf.Clamp(xRotation, MinXRotation, MaxXRotation);
        
        transform.GetChild(0).localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.localRotation = Quaternion.Euler(0, yRotation, 0);

    }
}
