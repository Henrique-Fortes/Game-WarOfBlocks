using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        //Imprime no console o nome do objeto que se colidiu com o bloco
        //Debug.Log(collision.gameObject.name);
    }
}
