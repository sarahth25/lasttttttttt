using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class COMPDD : MonoBehaviour
{

    public Text textBox;
    public Dropdown dropdown;
    public int index;

    // Start is called before the first frame update
    void Start()
    {

        dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        List<string> items = new List<string>();
        items.Add("Options");
        items.Add("IKEA");
        items.Add("ABYAT");
        items.Add("SAFAT HOME");
        items.Add("PIVOT");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });

        }
        dropdown.onValueChanged.AddListener(delegate { compdd(dropdown); });
 }
     void compdd(Dropdown dropdown)
    {
         index = dropdown.value;
        textBox.text = dropdown.options[index].text;
    }
     void Update()
    {
         index = dropdown.value;
        if (index != null)
        {
            
             //  if(index==0){
                   // load scene 0
                 //  SceneManager.LoadScene("Testtt");}
                //if(index==1){
                   
                    //SceneManager.LoadScene("6X4X6");}
                //else if(index==2){
                  
                   // SceneManager.LoadScene("8x4x4");}
                //else if(index==3){
                    //load scene 0
                    //SceneManager.LoadScene("10X8X10");}
                //else if(index==4){
                    //load scene 0
                   // SceneManager.LoadScene("12X6X12");}
                
                    
         }  
        }
    }


