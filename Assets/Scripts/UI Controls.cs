using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UIControls : MonoBehaviour {

    public float speed;
    public float jumpSpeed;
    public float gravity;


	// Use this for initialization
	public void Start () {
	    	
	}
	
	// Update is called once per frame
	public void Update () {
        float moveHorizontal;
        

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            transform.Translate(moveHorizontal, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            transform.Translate(0, moveHorizontal, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
	}
}
