using UnityEngine;

public class DemoLogger : MonoBehaviour
{
    private int logFrameCount;
    void Update()
    {
        if (logFrameCount++ % 240 == 0)
        {
            Debug.Log($"DemoLogger Update {logFrameCount}");
        }
    }
}
