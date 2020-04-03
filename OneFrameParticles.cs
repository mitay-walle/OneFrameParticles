using UnityEngine;

public class OneFrameParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] targets;
    [SerializeField] private int framesCount = 3;
    private ParticleSystem.MainModule[] mains;
    private bool inited;
    
    public void OnEnable()
    {
        Init();
        SetValues();
    }
    
    public void Init()
    {
        if (inited) return;
        
        mains = new ParticleSystem.MainModule[targets.Length];
        for (int i = 0; i < targets.Length; i++)
        {
            mains[i] = targets[i].main;
        }
        inited = true;
    }

    public void SetValues()
    {
        var delta = Time.deltaTime * framesCount;
        
        for (int i = 0; i < mains.Length; i++) mains[i].startLifetime = delta;
    }
}
