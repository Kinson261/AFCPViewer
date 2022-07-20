using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getDateAndTime : MonoBehaviour
{

    public string date;
    // Start is called before the first frame update
    public void Update() {
        date = System.DateTime.Now.ToString("dd-MM-yyyy_HH-mm");
    }
}
