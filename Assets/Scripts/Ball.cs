using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //Config params
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;


    //State
    Vector2 paddleToBallVector;
    bool hasStarted = false;

	// Use this for initialization
	void Start ()
    {
        paddleToBallVector = transform.position - paddle1.transform.position; 
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Se não clicar, a bola fica trancanda
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();            
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Se clicar, a bola não fica trancada
            hasStarted = true;
            //Acessar a bola, e sua velocidade que é 0, e incrementar a força do vector2 para impulsionar ela 
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        //Paddle vector "paddlePos" plus distance vector "paddleToBallVector"
        transform.position = paddlePos + paddleToBallVector;
    }
}
