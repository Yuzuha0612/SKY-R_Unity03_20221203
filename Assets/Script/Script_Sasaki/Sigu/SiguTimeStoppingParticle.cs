using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguTimeStoppingParticle : MonoBehaviour
{
    //ParticleSystem.ShapeModule SiguTimeStoppinngInParticleSystem;
    //private float SiguTimeStippingCircle;
    //2022/11/23追加 ゲーム開始判定
    bool isStart = false;
    // 時間停止の時にシグに集まるエフェクトを制御するスクリプト
    private Vector3 scale;
    private float Effectv;
    private float Effecth;
    void Start()
    {
        
        /* SiguTimeStoppinngInParticleSystem = GetComponent<ParticleSystem>().shape;
         SiguTimeStoppinngInParticleSystem.radius = 35;
         SiguTimeStippingCircle = 35;*/
    }

    void Update()
    {
        //ゲーム開始判定
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStart == true)
        {
            //左右キーのどちらかが押されたときエフェクトを小さくする
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {
                if (Effecth>0 || Effectv > 0) {
                    Effecth-=0.5f;
                    Effectv-=0.5f;
                    this.gameObject.transform.localScale = new Vector3(Effectv, Effecth, 1.0f);
                }
                else
                {
                    
                }
            }
            else
            {
                if (Effecth <6 || Effectv < 6)
                {
                    Effectv+=0.5f;
                    Effecth+=0.5f;
                    //左右キーのどちらかが押されたときエフェクトを大きくする
                    this.gameObject.transform.localScale = new Vector3(Effectv, Effecth, 1.0f);
                }else if(Effecth > 6 || Effectv > 6)
                {

                }
            }
        }
        /* SiguTimeStoppinngInParticleSystem.radius= SiguTimeStippingCircle;
         if(SiguTimeStippingCircle>1)
         {
             SiguTimeStippingCircle--;
         }else if(SiguTimeStippingCircle<1)
         {

         }*/
    }
}
