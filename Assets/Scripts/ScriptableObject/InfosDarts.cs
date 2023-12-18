using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosDarts", menuName = "SO/NouveauDarts")]
public class InfosDarts : ScriptableObject
{
    public int nbPointsDarts;
    public int nbPointsDartsGagner;

    private void onEnable()
    {
        nbPointsDarts = 0;
        nbPointsDartsGagner = 50;
    }
}
