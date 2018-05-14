using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public float sensibilite;
    public float saut;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Deplacement avec les bidings de Unity dans les inputs

        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);

        // Déplacement en fonction de la souris 

        transform.Rotate(0, Input.GetAxis("Mouse X")*sensibilite, 0);
        

        // Saut

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody> ().velocity = new Vector3(0, saut, 0);
        }

    }
}
