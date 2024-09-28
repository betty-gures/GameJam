using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ro : MonoBehaviour
{

    public float F_X;
    public float F_Y;
    public float F_Z;


    private void Awake()
    {
        F_X = F_X * 20f;
        F_Y = F_Y * 20f;
        F_Z = F_Z * 20f;
    }

    // Update is called once per frame
    void Update () {
		transform.Rotate(new Vector3(F_X*Time.deltaTime, F_Y * Time.deltaTime, F_Z * Time.deltaTime),Space.Self);
	}
}
