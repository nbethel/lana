using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Core;
using RAIN.Action;
using RAIN.Representation;

public class Mode : MonoBehaviour {
	public bool chasing = false;
	public float mode = 0f;
	
	void Start () {
	}
	
	void Update () {
	}

	public void set0() {
		//Debug.Log ("Set0"); //For wandering
		mode=0;
		//AI.WorkingMemory.SetItem("mode", mode);
	}
	public void set1() {
		//Debug.Log ("Set1"); //For Tracking
		mode=1;
		//AI.WorkingMemory.SetItem("mode", mode);

	}
	public void set2() {
		//Debug.Log ("Set2"); //For Chasing
		mode=2;
		//AI.WorkingMemory.SetItem("mode", mode);
	}
	public void set3() {
		//Debug.Log ("Set3"); //For Attacking
		mode=3;
		//AI.WorkingMemory.SetItem("mode", mode);
	}
	public void set4() {
		//Debug.Log ("Set4"); //For lost after chase
		mode=4;
		//AI.WorkingMemory.SetItem("mode", mode);
	}
}