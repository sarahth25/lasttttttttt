using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform pointer; 
    void Awake(){
        pointer = GameObject.FindGameObjectWithTag("sphere").transform;
    }
    
   public void drag (){
    transform.position = new Vector3(pointer.position.x, transform.position.y, pointer.position.z);

   }
}
