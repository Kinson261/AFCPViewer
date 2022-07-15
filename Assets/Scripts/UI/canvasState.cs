using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasState : MonoBehaviour
{
    public Canvas canvas;
    public bool enabledOnStart;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        if (enabledOnStart == true){
            canvas.enabled = true;
        }
        else{
            canvas.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
