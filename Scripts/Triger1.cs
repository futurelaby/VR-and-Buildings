using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger1 : MonoBehaviour {

    public Animator anim;
    public GameObject g;
	void Update () {
        //anim.SetBool("Toggle", false);

        ControllerScript Cs = g.GetComponent<ControllerScript>();
        Cs.Toggle = true;
	}
}
