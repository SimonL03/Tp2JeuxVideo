using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimePorte : MonoBehaviour
{
  public GameObject _Porte;
    public GameObject _Joueur;
    private Animator _animatorPorte;
    private Animator _animatorJoueur;
    [SerializeField] private AudioSource ChangeScene;



    // Start is called before the first frame update
    void Start()
    {
        _animatorPorte=_Porte.GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name==_Joueur.name)
        {

        _animatorPorte.SetTrigger("Ouvre");
        Debug.Log("Entrer");
        ChangeScene.Play();
        
        }
    }
}
