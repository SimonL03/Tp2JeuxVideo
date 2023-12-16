using System.Collections;
using System.Collections.Generic;
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

    void Update()
    {
        _nbNiveauText.text = "Vous avez terminé " + _infosNiveau.nbMiniJeuxTerminer.ToString() + " Jeux!";
        _nbTempEcoulerText.text = "Votre temp: " + "00:00:01";
    }
}
