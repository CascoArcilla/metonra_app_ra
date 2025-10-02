using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void MoveSceneDetalles()
    {
        SceneManager.LoadScene("DetallesScene");
    }
    public void MoveSceneTest()
    {
        SceneManager.LoadScene("TestScene");
    }
    public void MoveMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void MoveBienvenidaScene()
    {
        SceneManager.LoadScene("BienvenidaScene");
    }
    public void MoveLoginScene()
    {
        SceneManager.LoadScene("LoginScene");
    }
    public void MoveRegistrarseScene()
    {
        SceneManager.LoadScene("RegistrarseScene");
    }
    public void MoveTestGAD7Scene()
    {
        SceneManager.LoadScene("TestGAD7Scene");
    }
}