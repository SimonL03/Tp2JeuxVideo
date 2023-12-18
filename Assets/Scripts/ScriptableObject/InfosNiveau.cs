using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosNiveau", menuName = "SO/NouveauNiveau")]
public class InfosNiveau : ScriptableObject
{
    public int nbMiniJeuxTerminer;
    public float temps;
    public float tempsInitial;
    public int dartTerminer;
    public int basketTerminer;
    public int giftTerminer;
    public int exterieurTerminer;

    private void onEnable()
    {
        nbMiniJeuxTerminer = 0;
        temps = 0;
        tempsInitial = 600;
        dartTerminer = 0;
        basketTerminer = 0;
        giftTerminer = 0;
        exterieurTerminer = 0;
    }
}
