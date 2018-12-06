﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    //Configuration parameters
    [SerializeField] float screenWidhtInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Para ver a posição que o mouse esta localizado na tela
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidhtInUnits;
        //Vector2 é uma forma de armazenar coordenadas x e y
        //Transform position, ou seja em transfor > position do Unity  ele vai definir como 10f x, 4f y
        //Vector2 paddlePos = new Vector2(10f, 4f);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
	}
}
