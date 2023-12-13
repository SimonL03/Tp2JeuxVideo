using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueur : ScriptableObject
{
    // Start is called before the first frame update
    public string nomJoueur;
    [Space(10)]
    public string nomNiveau;
    [Space(10)]
    [Header("Nombre de panier points")]
    public int nbPoints;
    [Header("Nombre de Cle à trouver'")]
    public int nbCleATrouver;
    
}
