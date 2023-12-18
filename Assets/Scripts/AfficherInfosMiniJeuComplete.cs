using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfficherInfosMiniJeuComplete : MonoBehaviour
{
    [Header("Les informations gardées en mémoire")]
    [SerializeField]
    private InfosNiveau _infosNiveau;
    [SerializeField]
    private TMP_Text _nbJeuText;

    // Start is called before the first frame update
    void Update()
    {
        _nbJeuText.text = "Mini jeux complété: " + _infosNiveau.nbMiniJeuxTerminer.ToString();
    }
}
