using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts_game : MonoBehaviour
{
    //References des triggers
    [SerializeField] private GameObject zone1gauche;
    [SerializeField] private GameObject zone1droite;
    [SerializeField] private GameObject zone2haut;
    [SerializeField] private GameObject zone2bas;
    [SerializeField] private GameObject zone5gauche;
    [SerializeField] private GameObject zone5droite;
    [SerializeField] private GameObject zone10haut;
    [SerializeField] private GameObject zone10bas;
    [SerializeField] private GameObject zone30centre;

    //Prend la collision d'un trigger
    private void OnTriggerEnter(Collider other){
        if(this.gameObject == zone1gauche|| this.gameObject == zone1droite){
            Debug.Log("1 Points!");
        }
        if(this.gameObject == zone2haut|| this.gameObject == zone2bas){
            Debug.Log("2 Points!");
        }
        if(this.gameObject == zone5gauche|| this.gameObject == zone5droite){
            Debug.Log("5 Points!");
        }
        if(this.gameObject == zone10haut|| this.gameObject == zone10bas){
            Debug.Log("10 Points!");
        }
        if(this.gameObject == zone30centre){
            Debug.Log("30 Points!");
        }
    }
}
