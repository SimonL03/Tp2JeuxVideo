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
    [SerializeField] private GameObject zoneEchec;
    [SerializeField] private GameObject dart;
    [SerializeField] private InfosDarts _infoDarts;

    //A faire
    //Reset la position du dart quand il touche une zone, un mur ou le sol
    //Ajouter les points au joueur
    //Faire que apres 50 points on fini le mini-jeu

    //Prend la collision d'un trigger
    private void OnTriggerEnter(Collider other){
        // Vérifie quel objet a déclenché le script
        if(this.gameObject == zone1gauche|| this.gameObject == zone1droite){
            Debug.Log("1 Points!");
            _infoDarts.nbPointsDarts += 1;
            dart.transform.position = new Vector3 (0,0,0);
        }
        if(this.gameObject == zone2haut|| this.gameObject == zone2bas){
            Debug.Log("2 Points!");
            _infoDarts.nbPointsDarts += 2;
            dart.transform.position = new Vector3 (0,0,0);
        }
        if(this.gameObject == zone5gauche|| this.gameObject == zone5droite){
            Debug.Log("5 Points!");
            _infoDarts.nbPointsDarts += 5;
            dart.transform.position = new Vector3 (0,0,0);
        }
        if(this.gameObject == zone10haut|| this.gameObject == zone10bas){
            Debug.Log("10 Points!");
            _infoDarts.nbPointsDarts += 10;
            dart.transform.position = new Vector3 (0,0,0);
        }
        if(this.gameObject == zone30centre){
            Debug.Log("30 Points!");
            _infoDarts.nbPointsDarts += 30;
            dart.transform.position = new Vector3 (0,0,0);
        }
        if(this.gameObject == zoneEchec){
            dart.transform.position = new Vector3 (0,0,0);
        }
        if(_infosDarts.nbPointsDarts == 50){
            Debug.Log("Vous êtes le gagner! (La faute de français est nécessaire)");
        }
    }
}
