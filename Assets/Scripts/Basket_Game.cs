using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket_Game : MonoBehaviour
{
    [SerializeField] private GameObject _Ballon;
    [SerializeField] private InfoPointPanier _infosPanier;
    [SerializeField] private GameObject _Panier;
    [SerializeField] private InfosNiveau _infoNiveau;
    // Start is called before the first frame update
      private void OnTriggerEnter(Collider other){
        // Vérifie quel objet a déclenché le script
        if(this.gameObject == _Panier)
        {
            _infosPanier.nbPointsPanier += 1;
           
        }
    
        if (_infosPanier.nbPointsPanier >= _infosPanier.nbPointsPanierGagner){
                if(_infoNiveau.basketTerminer == 0){
                _infoNiveau.nbMiniJeuxTerminer++;
                _infoNiveau.basketTerminer +=1;
            }
        }
      }
}
