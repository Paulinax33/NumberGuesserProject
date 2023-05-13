using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using TMPro;
using UnityEngine.UI;

public class script2 : MonoBehaviour
{
    public TMP_InputField inputText;
    public Button button;
    public TMP_Text output;

    public string input_text;
    System.Random random = new System.Random();
    public int suprise_number;
    // Start is called before the first frame update
    void Start()
    {
      button.onClick.AddListener(CheckNumber);
    }
    //public void CheckNumber()
    //{
    //  suprise_number = Convert.ToInt32(inputText.text);
    //int comp_number = 0;
    //while(suprise_number != comp_number)
    //{
    //  comp_number = UnityEngine.Random.Range(1, 100);
    //if(suprise_number == comp_number) { output.text = "Good Number"; break; }
    //else if(suprise_number < suprise_number) { output.text = "Incorrect number"; }
    //else { output.text = "Incorrect number"; }
    //}
    //}

    // Update is called once per frame
    public void CheckNumber()
    {
        input_text = inputText.text;
        guess();
    }
    public void guess() 
    {
        int number_guessed = Convert.ToInt32(input_text);
        for (suprise_number = 0; suprise_number <= 100; suprise_number = random.Next(101))
        {
            Debug.Log(suprise_number);
            if (number_guessed == suprise_number) { output.text = "GOOD NUMBER"; break;}
            else if (number_guessed < suprise_number) { output.text = "INCORRECT NUMBER";}
            else { output.text = "BIGGER NUMBER"; }
            }
        }
    void Update()
    {
        
    }
}
