using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escapar : MonoBehaviour
{

    public bool Trancada;
    public float Distancia = 10;
    public float tempoDoAviso = 2;

    public AudioClip audioPortaAbrindo, audioPortaTrancada, audioDestrancandoPorta;
    private bool avisoPortaTrancada, ativarCarregamento;
    public bool temAChave; 
    public int IDdaChave;
    private GameObject Jogador;
    private float cronometroAviso, cronometroCarregamento;
    void Start() {
        cronometroAviso = 0;
        cronometroCarregamento = 0;
        avisoPortaTrancada = false;
        ativarCarregamento = false;
        Jogador = GameObject.FindWithTag("Player");


    }
    void Update () {
        if (Vector3.Distance(Jogador.transform.position,transform.position) <= Distancia && Input.GetKeyDown("e")) {
            if (Trancada == true && temAChave == false) {
                avisoPortaTrancada = true;
                GetComponent<AudioSource> ().PlayOneShot(audioPortaTrancada);

            }
            else if (Trancada == true && temAChave == true) {
                Trancada = false;
                GetComponent<AudioSource> ().PlayOneShot(audioDestrancandoPorta);
            }
            else if(Trancada == false) {
                ativarCarregamento = true;
                GetComponent<AudioSource> ().PlayOneShot(audioPortaAbrindo);
            }
        }
        if (avisoPortaTrancada == true) {
            cronometroAviso += Time.deltaTime;
        }
        if (cronometroAviso >= tempoDoAviso) {
            avisoPortaTrancada = false;
            cronometroAviso = 0;
        }
        if (ativarCarregamento == true) {
            cronometroCarregamento += Time.deltaTime;
        }
        if (cronometroCarregamento >= 1) {
            SceneManager.LoadScene(2);
    }

    }
}
