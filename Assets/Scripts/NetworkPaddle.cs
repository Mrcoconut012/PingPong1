using Mirror;
using UnityEngine;
using Valve.VR;

public class NetworkPaddle : NetworkBehaviour
{
    [SyncVar] // Позиция синхронизируется между клиентами
    private Vector3 syncPosition;

    [SyncVar]
    private Quaternion syncRotation;

    public SteamVR_Input_Sources handType;
    public SteamVR_Behaviour_Pose controllerPose;

    void Update()
    {
        if (isLocalPlayer)
        {
            // Обновляем позицию только на локальном клиенте
            UpdatePosition();
        }
        else
        {
            // Для других игроков используем синхронизированные значения
            transform.position = syncPosition;
            transform.rotation = syncRotation;
        }
    }

    [Command]
    void UpdatePosition()
    {
        // Передаем позицию на сервер
        syncPosition = controllerPose.transform.position;
        syncRotation = controllerPose.transform.rotation;
    }
}