using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class StartUp {
    
    static StartUp()
    {
        ServerConnection instance = ServerConnection.GetInstance();
        instance.CreateConnection();

    }

}
