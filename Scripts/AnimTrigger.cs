using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour {

    Animator anim; 
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PointerEnter ()
    {
        anim.SetBool("Start",true);
    }

    public void PointerExit ()
    {
        anim.SetBool("Start", false);
    }
}
