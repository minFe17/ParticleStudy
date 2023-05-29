
using UnityEngine;

public class FireWorks : MonoBehaviour
{
    [SerializeField] ParticleSystem _fireworks;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _fireworks.Emit(1);
    }
}
