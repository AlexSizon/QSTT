using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public void StartGame(Rigidbody SphereBody)
    {
        SphereBody.useGravity = true;
        PlateRoataion.isGameStarted = true;
    }
    public void DisActivePanel(GameObject Panel)
    {
        Panel.SetActive(false);
    }
    public void RestatrtGame(Rigidbody SphereBody)
    {
        SceneManager.LoadScene(0);
        StartGame(SphereBody);
    }
}
