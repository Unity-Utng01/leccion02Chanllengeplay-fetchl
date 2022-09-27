using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
Descripción: Para que se destruyan los objetos que se encuentran en el prefast
Autor: Eva Quintero Carrillo
Date:27/09/2022

**/
public class DestroyOutOfBoundsX : MonoBehaviour
{
    //se modificaron los limites
    private float leftLimit = -38;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        //< se cambio   
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
