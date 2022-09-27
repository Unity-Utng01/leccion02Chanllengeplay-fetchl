using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripción:  En este script salen los perro al precionar el space y sale uno por el tiempo de disparo con el tiempo de espera 
no salen en glomeración 
Autor: Eva Quintero Carrillo
Date:27/09/2022
**/
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
      private float tiempoEsp =1;
    private float tiempoDisparo = 0;

    // Update is called once per frame
    void Update()
    {
      
        // On spacebar press, send dog
        //se le agrego el tiempode disparo
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoDisparo)
        {   
            //con eso solo aparece un perro por los tiempos 
            tiempoDisparo = Time.time + tiempoEsp;
            //aquí instancia copias del perro en la posicion del jugador
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}
