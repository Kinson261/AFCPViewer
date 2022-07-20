using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

using TMPro;

public class saveParameters3 : MonoBehaviour
{
    public TMP_InputField inputFieldR;
    public TMP_InputField inputFieldB;

    public float R;
    public float B;

    string date;
    public getDateAndTime m_date;



    void Start(){
        // initialization
        inputFieldR.text = "1";
        inputFieldB.text = "1";

        //converting string to floating
        float.TryParse(inputFieldR.text, out R);
        float.TryParse(inputFieldB.text, out B);

        // add listener to value change of input field
        inputFieldR.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldB.onEndEdit.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck(){
        //converting string to floating
        float.TryParse(inputFieldR.text, out R);
        float.TryParse(inputFieldB.text, out B);
    }
    

    public void onClick(){
        date = m_date.date;

        Directory.CreateDirectory(Application.streamingAssetsPath  + date + "/Parameters/");
        
        createTxtFile();
    }
    

    public void createTxtFile(){
        string docname = Application.streamingAssetsPath + date + "/Parameters/" +  "/parametersSpatialBlade.txt";

        if (!File.Exists(docname)){
            File.WriteAllText(docname, "Параметры пространственной лопасти\n");
        }

        File.AppendAllText(docname, "\nR = " + R);
        File.AppendAllText(docname, "\nB = " + B);
    }

}
