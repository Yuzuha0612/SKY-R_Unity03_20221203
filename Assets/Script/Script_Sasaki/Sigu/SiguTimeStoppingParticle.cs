using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguTimeStoppingParticle : MonoBehaviour
{
    //ParticleSystem.ShapeModule SiguTimeStoppinngInParticleSystem;
    //private float SiguTimeStippingCircle;
    //2022/11/23�ǉ� �Q�[���J�n����
    bool isStart = false;
    // ���Ԓ�~�̎��ɃV�O�ɏW�܂�G�t�F�N�g�𐧌䂷��X�N���v�g
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
        //�Q�[���J�n����
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStart == true)
        {
            //���E�L�[�̂ǂ��炩�������ꂽ�Ƃ��G�t�F�N�g������������
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
                    //���E�L�[�̂ǂ��炩�������ꂽ�Ƃ��G�t�F�N�g��傫������
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
