using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;



public class ButtonMng : MonoBehaviour
{
    public void GameStartBtn()
    {
        SceneManager.LoadScene(1);
    }
}
