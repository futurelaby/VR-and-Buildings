using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger2 : MonoBehaviour {

    public Animator anim;
    public GameObject g;

	void Update () {
        //anim.SetBool("Toggle", true);
        ControllerScript Cs = g.GetComponent<ControllerScript>();
        Cs.Toggle = true;
	}
}
