using System;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private string userId = Guid.NewGuid().ToString();
    void Start()
    {
        SingularSDK.InitializeSingularSDK();
        SingularSDK.SetCustomUserId(userId);
        RequestFriendInviteLink();
    }

    private void RequestFriendInviteLink()
    {
        void callback(string shortLinkURL, string error){
            Debug.LogError("SingularSDKlink: " + shortLinkURL);
        }

        SingularSDK.createReferrerShortLink(
            "https://test.sng.link/Diqpz/mjo5",
            "John", // Referrer Name
            userId, // Referrer ID
            new Dictionary<string, string>()
            {
                // a Dictionary object containing any parameters you want to add
                { "channel", "sms" }
            },
            callback);
    }
}
