﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Paddle : MonoBehaviour {
    public int i = 0;
    //Make the AudioClip configurable in the editor
    public AudioClip Sound;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.mousePosition);
        //this code will be intergrated to andriod devices.this.transform.position.x
        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        //Get mouse position
        float mousePos = Input.mousePosition.x / Screen.width * 16;
        //Set new mouse X position
        paddlePos.x = Mathf.Clamp(mousePos, 0.5f, 15.5f);
        //Change paddle to match new X position
        this.transform.position = paddlePos;
    }

    //OnCollisionEnter will only be called when one of the colliders has a
   // rigidbody
    void OnCollisionEnter2D(Collision2D c)
    {
        //Change the sound pitch if a slowdown powerup has been picked up
        GetComponent<AudioSource>().pitch = Time.timeScale;
        //Play it once for this collision hit
        GetComponent<AudioSource>().PlayOneShot(Sound);
    }
}
