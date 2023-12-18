using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class AfficherInfosFin : MonoBehaviour
{
    [Header("Les informations gardées en mémoire")]
    [SerializeField]
    private InfosNiveau _infosNiveau;
    [SerializeField]
    private TMP_Text _nbNiveauText;
    [SerializeField]
    private TMP_Text _nbTempEcoulerText;

    void Start()
    {
        float temps = _infosNiveau.temps;

        //convertir la variable en temps en seconde
        TimeSpan ts = TimeSpan.FromSeconds(temps);

        _nbNiveauText.text = "Vous avez terminé " + _infosNiveau.nbMiniJeuxTerminer.ToString() + " Jeux!";
        _nbTempEcoulerText.text = "Votre temp: " + string.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
