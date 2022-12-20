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
    public void CalculateCost90()
    {
        Costt += 90 ;
    }
     public void CalculateCost40()
    {
        Costt += 40 ;
    }

    public void DecrmentCost50()
    {
        if(Costt > 0) 
        Costt -= 50;
        
    }
    public void DecrmentCost90()
    {
         if(Costt > 0) 
        Costt -= 90;
    }
    public void DecrmentCost40()
    {
         if(Costt > 0) 
        Costt -= 40;
    }
}

