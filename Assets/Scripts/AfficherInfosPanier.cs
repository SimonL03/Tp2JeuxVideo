using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfficherInfosPanier : MonoBehaviour
{
    [Header("Les informations gardées en mémoire")]
    [SerializeField]
    private InfoPointPanier _infosPanier;
    [SerializeField]
    private TMP_Text _nbPointsText;

    // Start is called before the first frame update
    void Start()
    {
        _infosPanier.nbPointsPanier = 0;
    }

    void Update()
    {
        _nbPointsText.text ="Panier"+ _infosPanier.nbPointsPanier.ToString();
    }
}

