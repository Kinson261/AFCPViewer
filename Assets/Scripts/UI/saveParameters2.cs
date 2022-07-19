using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class saveParameters2 : MonoBehaviour
{
    public TMP_InputField inputFieldD1;
    public TMP_InputField inputFieldD2;
    public TMP_InputField inputFieldB1;
    public TMP_InputField inputFieldB2;

    public float D1;
    public float D2;
    public float B1;
    public float B2;



    void Start(){
        // initialization
        inputFieldD1.text = "1";
        inputFieldD2.text = "1";
        inputFieldB1.text = "1";
        inputFieldB2.text = "1";

        //converting string to floating
        float.TryParse(inputFieldD1.text, out D1);
        float.TryParse(inputFieldD2.text, out D2);
        float.TryParse(inputFieldB1.text, out B1);
        float.TryParse(inputFieldB2.text, out B2);

        // add listener to value change of input field
        inputFieldD1.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldD2.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldB1.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldB2.onEndEdit.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck(){
        //converting string to floating
        float.TryParse(inputFieldD1.text, out D1);
        float.TryParse(inputFieldD2.text, out D2);
        float.TryParse(inputFieldB1.text, out B1);
        float.TryParse(inputFieldB2.text, out B2);
    }
    

    void getValue(){

    }
}