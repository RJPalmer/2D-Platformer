using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUIControl : MonoBehaviour {

    public float playerSpeed;
    private KeyCode lastKeyPressed;
	// Use this for initialization
	void Start () {
        lastKeyPressed = new KeyCode();
	}
	
	// Update is called once per frame
	void Update () {

        float moveHorizontal;

        //First key press is Right Arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
            transform.Translate(moveHorizontal, 0, 0);
            playerSpeed += Time.deltaTime;
            lastKeyPressed = KeyCode.RightArrow;
            
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
            transform.Translate(moveHorizontal, 0, 0);
            playerSpeed += Time.deltaTime;
            lastKeyPressed = KeyCode.RightArrow;

        }

        if (Input.GetKey(KeyCode.LeftArrow) && lastKeyPressed.CompareTo(KeyCode.RightArrow).Equals(0))
        {
            playerSpeed = 1;
            moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
            transform.Translate(moveHorizontal, 0, 0);
            playerSpeed += Time.deltaTime;
            lastKeyPressed = KeyCode.LeftArrow;
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
            transform.Translate(moveHorizontal, 0, 0);
            playerSpeed += Time.deltaTime;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }

    }
}
