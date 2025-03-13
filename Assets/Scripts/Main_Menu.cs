using Mirror;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    private NetworkManager manager;

    void Start()
    {
        manager = FindObjectOfType<NetworkManager>();
    }

    public void OnHostButtonClick()
    {
        manager.StartHost();
    }

    public void OnJoinButtonClick()
    {
        manager.StartClient();
    }
}