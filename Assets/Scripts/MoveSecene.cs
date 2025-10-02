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
}