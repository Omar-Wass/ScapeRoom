using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private string Level1;
    
    [SerializeField] private GameObject painelOpcoes;



    public void StartGame() 
    {
        SceneManager.LoadScene("Fase 1");
    }

    public void AbrirOpcoes() 
    {
        painelOpcoes.SetActive(true);
    }


    public void FecharOpcoes() 
    {
        painelOpcoes.SetActive(false);
    }
    public void SairJogo() 
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
