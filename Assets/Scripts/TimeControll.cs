using UnityEngine;

public class TimeControll : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Time.timeScale = 0;
        if (Input.GetMouseButtonDown(1))
            Time.timeScale = 2;
    }

    private void OnParticleSystemStopped()
    {
        Debug.Log("파티클 동작 종료");
    }
}
