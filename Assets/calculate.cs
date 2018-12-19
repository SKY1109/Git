using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculate : MonoBehaviour {

    int a, b,c;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int calculate1(int a,int b) {

        c = a % b;
        return c;
    }
}
