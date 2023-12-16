using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosNiveau", menuName = "SO/NouveauNiveau")]
public class InfosNiveau : ScriptableObject
{
    public int nbMiniJeuxTerminer;

    private void onEnable()
    {
        nbMiniJeuxTerminer = 0;
    }
}
