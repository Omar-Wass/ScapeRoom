using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TelaVencer : MonoBehaviour
{

    public void VoltarMenu() {
        SceneManager.LoadScene(0);
    }

    public void FecharJogo() {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }

}
