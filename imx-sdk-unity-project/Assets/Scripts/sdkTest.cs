using System;
using System.Collections;
using System.Collections.Generic;
using api.Api;
using api.Client;
using api.Model;
using UnityEngine;

public class sdkTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Configuration config = new Configuration();
        config.BasePath = "https://api.sandbox.x.immutable.com";
        
        // Testing asset lists
        var apiInstance = new AssetsApi(config);
        
        try
        {
            // Get a list of assets
            ListAssetsResponse result = apiInstance.ListAssets();
            Debug.Log(result.ToJson());
        }
        catch (ApiException  e)
        {
            Debug.Log("Exception when calling AssetsApi.ListAssets: " + e.Message);
            Debug.Log("Status Code: " + e.ErrorCode);
            Debug.Log(e.StackTrace);
        }
        
        // Testing getting users
        var usersInstance = new UsersApi();
        
        try
        {
            GetUsersApiResponse result = usersInstance.GetUsers("0x7b680319568a55bf60e94291cDf4E939d603cE96");
            Debug.Log(result.ToJson());
        }
        catch (ApiException e)
        {
            Debug.Log("Exception when calling UsersApi.GetUsers: " + e.Message);
            Debug.Log("Status Code: " + e.ErrorCode);
            Debug.Log(e.StackTrace);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
