using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueurs : ScriptableObject
{
    [Header("Points du joueur")]
    public int nbPointsDarts;
    public int nbPointsDartsGagner;
    public int nbTempsRestant;
    public int nbTempsInitial;

    private void onEnable()
    {
        nbPointsDarts = 0;
        nbTempsRestant = 0;
        nbTempsInitial = 0;
        nbPointsDartsGagner = 50;
    }
}
