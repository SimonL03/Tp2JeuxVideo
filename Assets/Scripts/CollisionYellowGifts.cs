using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionYellowGifts : MonoBehaviour
{

    [SerializeField] GameObject ZoneYellowBowGift;
    [SerializeField] private InfosGifts _infosGifts;
    [SerializeField] private int _nbPoints;
    [SerializeField] private AudioClip _placeGift;
     private AudioSource audioSource;
    private Vector3 _positionSpot;

    void Start()
    {
        _positionSpot = ZoneYellowBowGift.transform.position;
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "YellowBowGift"){
                Debug.Log("weihsogf");
                other.gameObject.transform.position = _positionSpot;
               
                _infosGifts.nbPointsGifts += _nbPoints;
                audioSource.clip = _placeGift;
                audioSource.Play();
                Invoke("DisableZoneGift", 1.0f);
            }   
    }
    private void DisableZoneGift(){
        ZoneYellowBowGift.SetActive(false);
    }
}
