using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lapin : MonoBehaviour {

    public float Multspeed;
    private float timer=0;

    void Start () {
		
	}
	
	
	void Update () {

        float random = Random.Range(-180, 180);
        float Speed = Time.deltaTime * Multspeed;
        timer += Time.deltaTime;
        if (timer > 0.4f)

        {
            timer = 0;
            Rigidbody l = GetComponent<Rigidbody>();
            l.AddForce(new Vector3(Speed*random, 0, 0));
            l.AddForce(new Vector3(0, 0, Speed * random));

        }



    }
}
