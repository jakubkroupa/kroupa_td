using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishManager : MonoBehaviour
{
    public static FinishManager instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject finish;
}
