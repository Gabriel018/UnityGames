using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Forca = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      var  lateral =  Input.GetAxis("Horizontal");
           if(GetComponent<Rigidbody>().velocity.magnitude <=22f)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(lateral * Forca, 0, 0));
        }
           
        
           
    }
}