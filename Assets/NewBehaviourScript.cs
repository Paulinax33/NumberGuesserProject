using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public TMP_InputField inputText;
    public Button button;
    public TMP_Text output;

    System.Random random = new System.Random();
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        i = random.Next(101);
        button.onClick.AddListener(checkNumber);
    }
    
    public void checkNumber()
    {
        string input_text = inputText.text;
        int suprise_number = Convert.ToInt32(input_text);
        if (suprise_number == i) { output.text = "Good Number"; }
        else if (suprise_number < i) { output.text = "Lower number"; }
        else { output.text = "Bigger number"; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
