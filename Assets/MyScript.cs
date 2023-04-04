using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MyScript : MonoBehaviour
{
    
    public FixedTouchField Touchfield;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();


        
        fps.mouseLook.LookAxis = Touchfield.TouchDist;


    }
}

