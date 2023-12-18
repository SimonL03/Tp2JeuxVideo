using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfficherInfosDarts : MonoBehaviour
{
    [Header("Les informations gardées en mémoire")]
    [SerializeField]
    private InfosDarts _infosDarts;
    [SerializeField]
    private TMP_Text _nbPointsText;

    // Start is called before the first frame update
    void Start()
    {
        _infosDarts.nbPointsDarts = 0;
    }

    void Update()
    {
        _nbPointsText.text = "Nombre de points: " + _infosDarts.nbPointsDarts.ToString();
    }
}
