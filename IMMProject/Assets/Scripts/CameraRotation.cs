using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float xCameraRotationSpeed = 3f;
    public float yCameraRotationSpeed = 3f;
    float verticalInput = 0.0f;
    float horizontalInput = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //get input for horizontal and vertical movement
        verticalInput = verticalInput + xCameraRotationSpeed * Input.GetAxis("Mouse Y");
        horizontalInput = horizontalInput - yCameraRotationSpeed * Input.GetAxis("Mouse X");
        float yLimits = Mathf.Clamp(verticalInput,-90f,90);

        transform.eulerAngles = new Vector3(yLimits, horizontalInput, 0.0f);

    }
}
