using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguTimeStoppingParticle : MonoBehaviour
{
    ParticleSystem SiguTimeStoppinngInParticleSystem;
    // 時間停止の時にシグに集まるエフェクトを制御するスクリプト
    void Start()
    {
        SiguTimeStoppinngInParticleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        
    }
}
