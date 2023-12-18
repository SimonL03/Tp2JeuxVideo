using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueur : ScriptableObject
{
    // Start is called before the first frame update

    [Header("Nombre de Cle à trouver'")]
    public int nbCleATrouver;
    
}
