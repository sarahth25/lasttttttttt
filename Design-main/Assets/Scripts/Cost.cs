using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost : MonoBehaviour
{
    public int Costt;
    public Text CosttText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CosttText.text = Costt.ToString();
    }

    public void CalculateCost()
    {
        Costt += 50 ;
    }
}

