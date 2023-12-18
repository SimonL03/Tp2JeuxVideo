using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollisionRedGifts : MonoBehaviour
{
    [SerializeField] private GameObject ZoneRedBowGift;
    [SerializeField] private InfosGifts _infosGifts;
    [SerializeField] private int _nbPoints;
    [SerializeField] private TMP_Text _textPointsGifts;
    [SerializeField] private AudioClip _placeGift;
     private AudioSource audioSource;
    private Vector3 _positionSpot;
    // Start is called before the first frame update
    void Start()
    {
        _positionSpot = ZoneRedBowGift.transform.position;
        audioSource = GetComponent<AudioSource>(); 
    }
    void Update(){
       _textPointsGifts.text = _infosGifts.nbPointsGifts.ToString();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "RedBowGift"){
                other.gameObject.transform.position = _positionSpot;
                
                _infosGifts.nbPointsGifts += _nbPoints;
                audioSource.clip = _placeGift;
                audioSource.Play();
                Invoke("DisableZoneGift", 1.0f);
            }
        
    }
    private void DisableZoneGift(){
        ZoneRedBowGift.SetActive(false);
    }
}
