using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class getDateAndTime : MonoBehaviour
{

    public string date;
    // Start is called before the first frame update
    public void Start() {
        date = System.DateTime.Now.ToString("dd-MM-yyyy_HH-mm");
        Directory.CreateDirectory(Application.streamingAssetsPath  + "/../../SavedModels/" + date);
    }
}
