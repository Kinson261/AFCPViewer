using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cineCamControl : MonoBehaviour
{

    public Camera camera;
    //public CineCam camera
    public float linearSpeed;
    public float rotationSpeed;
    public float zoomSpeed;
    public float scroll;
    public GameObject target;
    public Vector3 mousePos;
    public Vector3 offset;

    // zoom
    private float ZoomMinBound = 0.1f;
	private float ZoomMaxBound = 1000f;

    
    // Start is called before the first frame update
    void Start()
    {
        //camera = getComponent<CineCam>();
        camera = GetComponent<Camera>();
        camera.orthographic = true;
        mousePos = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {
        // do something
    }

    public void FixedUpdate(){
        

        if (Input.GetMouseButton(0)){           // left click to rotate object
            Debug.Log("rotate");
            if (Input.GetAxisRaw("Mouse X") != 0 || Input.GetAxisRaw("Mouse Y") != 0){
                target.transform.RotateAround(target.transform.position, Vector3.up, -Input.GetAxisRaw("Mouse X") * rotationSpeed * Time.deltaTime);
                target.transform.RotateAround(target.transform.position, Vector3.right, -Input.GetAxisRaw("Mouse Y") * rotationSpeed * Time.deltaTime);
                //target.transform.Rotate(Vector3.up * -Input.GetAxisRaw("Mouse X") * rotationSpeed * Time.deltaTime);
                //target.transform.Rotate(Vector3.right * Input.GetAxisRaw("Mouse Y") * rotationSpeed * Time.deltaTime);
            }

        }

        if (Input.GetMouseButton(1)){           // right click to move camera
            Debug.Log("Pressed right click.");
            if (Input.GetAxisRaw("Mouse X") != 0 || Input.GetAxisRaw("Mouse Y") != 0){
                camera.transform.position += linearSpeed * new Vector3(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"), 0) * Time.deltaTime;
            }
        }


        if(Input.GetMouseButton(2)){            // middle click to rotate camera
            Debug.Log("Pressed middle click.");

            if (Input.GetAxisRaw("Mouse X") != 0 || Input.GetAxisRaw("Mouse Y") != 0){
                camera.transform.RotateAround(target.transform.position, Vector3.up, Input.GetAxisRaw("Mouse X") * rotationSpeed * Time.deltaTime);
                camera.transform.RotateAround(target.transform.position, Vector3.right, Input.GetAxisRaw("Mouse Y") * rotationSpeed * Time.deltaTime);
            }
        }

        // zoom
        if (camera.orthographic){
            if (Input.GetAxis("Mouse ScrollWheel") < 0){
                camera.orthographicSize += zoomSpeed;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0){
                camera.orthographicSize -= zoomSpeed;
            }
            camera.orthographicSize = Mathf.Clamp(camera.orthographicSize,ZoomMinBound, ZoomMaxBound);
        }
        else{
            if (Input.GetAxis("Mouse ScrollWheel") < 0){
                camera.fieldOfView += zoomSpeed;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0){
                camera.fieldOfView -= zoomSpeed;
            }
            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView,ZoomMinBound, ZoomMaxBound);
        }    
    }



    public void findObject(){
        target = GameObject.FindGameObjectWithTag("model3d");
        camera.transform.position = new Vector3(target.transform.position.x + offset.x,
                                                target.transform.position.y + offset.y,
                                                target.transform.position.z + offset.z);
        camera.transform.LookAt(target.transform);
    }

    public void Zoom(float deltaMagnitudeDiff, float speed){
        camera.fieldOfView += deltaMagnitudeDiff * speed;
        // set min and max value of Clamp function upon your requirement
		camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, ZoomMinBound, ZoomMaxBound);
    }
}
