using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Camera camera;
    public float speed = 1.0f;
    public float zoomSpeed = 1.0f;
    public float zoom = 1.0f;
    public float sensivityX = 100.0f;
    public float sensivityY = 100.0f;
    public float rotationSpeed = 1.0f;
    public Vector3 mousePos;
    public Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        camera.orthographic = true;
        zoom = camera.orthographicSize;
    }


    private void FixedUpdate()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetMouseButton(2))
        {
            zoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
            camera.orthographicSize = zoom;
        }
        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = camera.ScreenToWorldPoint(mousePos);
            transform.position = Vector3.Lerp(transform.position, mousePos, speed * Time.deltaTime);
        }
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(transform.position, Vector3.right, Input.GetAxis("Mouse Y") * rotationSpeed);
            transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed);
        }
    }
}
