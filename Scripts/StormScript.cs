using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormScript : MonoBehaviour {
    
    public GameObject C;
    ControllerScript CS;
    public Animator anim;
    // Use this for initialization
	void Start () {
        
        CS = C.GetComponent<ControllerScript>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Toggle", CS.Toggle);
	}

    public void PointerEnter()
    {
        anim.SetBool("Pop", true);
    }

    public void PointerExit()
    {
        anim.SetBool("Pop", false);
        CS.Toggle = false;
    }
}
