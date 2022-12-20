using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removing4 : MonoBehaviour
{
    public GameObject y;
   //public Transform position;
    //public GameObject canvas;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void delete_furn(  )
    {
        GameObject y = GameObject.FindGameObjectWithTag("tag5f");
        Destroy(y);
    }
}

