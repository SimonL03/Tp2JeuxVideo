using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosNiveau", menuName = "SO/NouveauNiveau")]
public class InfosNiveau : ScriptableObject
{
    public int nbMiniJeuxTerminer;
    public float temps;
    public float tempsInitial;

    private void onEnable()
    {
        nbMiniJeuxTerminer = 0;
        temps = 0;
        tempsInitial = 600;
    }
}
