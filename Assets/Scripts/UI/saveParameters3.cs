using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class saveParameters3 : MonoBehaviour
{
    public TMP_InputField inputFieldR;
    public TMP_InputField inputFieldB;

    public float R;
    public float B;



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
    

    void getValue(){

    }
}
