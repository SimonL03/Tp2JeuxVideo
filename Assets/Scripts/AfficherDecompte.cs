using UnityEngine;
using TMPro;
using System;

public class AfficherDecompte : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau _infosNiveau;

    [SerializeField]
    private TMP_Text _champTexteTemps;

    public void AfficherTemps()
    {
        float temps = _infosNiveau.temps;

        if(temps < 0)
        {
            temps = 0;
        }

        //convertir la variable en temps en seconde
        TimeSpan ts = TimeSpan.FromSeconds(temps);

        // 00:00:00:000 (heures, minutes, secondes, millisecondes)
        _champTexteTemps.text = string.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
