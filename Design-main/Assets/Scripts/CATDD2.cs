using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CATDD2 : MonoBehaviour
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
        items.Add("Sofa");
        items.Add("Lamps");
        items.Add("Chairies");


        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });

        }
        dropdown.onValueChanged.AddListener(delegate { catdd(dropdown); });
    }

    void catdd(Dropdown dropdown)
    {
        index = dropdown.value;
        textBox.text = dropdown.options[index].text;
    }

    // Update is called once per frame
    void Update()
    {
        index = dropdown.value;
        if (index != null)
        {

            //  if(index==0){
            // load scene 0
            //  SceneManager.LoadScene("Testtt");}
            if (index == 1)
            {

                SceneManager.LoadScene("10X8X10sofa");
            }
            else if (index == 2)
            {

                SceneManager.LoadScene("10X8X10lamb");
            }
            else if (index == 3)
            {
                //load scene 0
                SceneManager.LoadScene("10X8X10charies");
            }
            //else if(index==4){
            //load scene 0
            //SceneManager.LoadScene("12X6X12");}


        }
    }

}

