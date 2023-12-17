using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket_Game : MonoBehaviour
{
    [SerializeField] private GameObject _Ballon;
    [SerializeField] private InfoPointPanier _infosPanier;
    [SerializeField] private GameObject _Panier;
    // Start is called before the first frame update
      private void OnTriggerEnter(Collider other){
        // Vérifie quel objet a déclenché le script
        if(this.gameObject == _Panier){
            Debug.Log("1 Points!");
            _infosPanier.nbPointsPanier += 1;
           
        }
    }
}
