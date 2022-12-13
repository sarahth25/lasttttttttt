using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adding : MonoBehaviour
{
    public GameObject furn;
    public Transform position;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void create_furn()
    {
        Instantiate(furn, position);
        canvas.SetActive(false);
    }
}
