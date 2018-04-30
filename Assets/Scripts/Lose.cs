using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private Ball ball;
    private GameManager gameManager;
    IEnumerator Pause()
    {
        print("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        //Switch GameManager State
        gameManager = GameObject.FindObjectOfType<GameManager>();
        gameManager.SwitchState(GameState.Failed);
        //Find the ball and reset game start
        // ball = GameObject.FindObjectOfType<Ball>();
        //  ball.gameStarted = false;
        //Reload level
        // Application.LoadLevel(Application.loadedLevel);

        //enable the restart and main menu buttons
        gameManager.EnableButtons();
        print("After Waiting 2 Seconds");
    }
   
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.name == "Ball")
        {
            print("Lost Triggered!");
            //Wait before restarting level
            StartCoroutine(Pause());
        }
    }

}
