using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DeltaDNA;

public class ddnaTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DDNA.Instance.SetLoggingLevel(DeltaDNA.Logger.Level.DEBUG);
        DDNA.Instance.StartSDK();

    }

    public void RecordOneSignalStatusEvent(OSSubscriptionState subscriptionState)
    {
        if (subscriptionState != null)
        {
            GameEvent e = new GameEvent("oneSignalPermissionState")
                .AddParam("oneSignalSubscribed", subscriptionState.subscribed)
                .AddParam("oneSignalUserID", subscriptionState.userId);                

            DDNA.Instance.RecordEvent(e);

        }
    }

}
