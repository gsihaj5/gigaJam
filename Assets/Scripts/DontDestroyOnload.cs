using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DontDestroyOnload : MonoBehaviour
{
    private static DontDestroyOnload _instance;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }
}