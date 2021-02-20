using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private NetworkManagerLobby networkManagerLobby = null;

    [SerializeField] private GameObject landingPagePanel = null;

    public void HostLobby()
    {
        networkManagerLobby.StartHost();

        landingPagePanel.SetActive(false);

        //new scene
    }
}
