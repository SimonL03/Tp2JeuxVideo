using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "InfosPanier", menuName = "SO/PanierPoint")]
public class InfoPointPanier : ScriptableObject
{
    public int nbPointsPanier;
    public int nbPointsPanierGagner;

    private void onEnable()
    {
        nbPointsPanier = 0;
        nbPointsPanierGagner = 3;
    }
}
