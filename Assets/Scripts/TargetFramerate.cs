using UnityEngine;

public class TargetFramerate : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = (int)Screen.currentResolution.refreshRateRatio.value;
    }
}
