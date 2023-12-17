using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetInfosStart : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau _infosNiveau;
    [SerializeField]
    private InfosJoueur _infosJoueur;
    [SerializeField]
    private InfoPointPanier _infosPointPanier;
    [SerializeField]
    private InfosDarts _infosDarts;
    [SerializeField]
    private InfosGifts _infosGifts;
    // Start is called before the first frame update
    void Start()
    {
        _infosNiveau.nbMiniJeuxTerminer = 0;
        _infosNiveau.tempsInitial = 600;
        _infosNiveau.temps = _infosNiveau.tempsInitial;

        _infosJoueur.nbCleATrouver = 0; //A changer?

        _infosPointPanier.nbPointsPanier = 0;
        _infosPointPanier.nbPointsPanierGagner = 10;

        _infosDarts.nbPointsDarts = 0;
        _infosDarts.nbPointsDartsGagner = 50;

        _infosGifts.nbPointsGifts = 0;
    }

}
