using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removing : MonoBehaviour
{
    public GameObject x;
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
        GameObject x = GameObject.FindGameObjectWithTag("tag1f");
        Destroy(x);
    }
}

