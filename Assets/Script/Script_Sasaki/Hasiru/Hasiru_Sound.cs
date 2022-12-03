using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AddComponento��Audio��AudioSource�Ŏ�l����AudioSource�����Ă�������(AudioClip��None�ő��v�ł�)
public class Hasiru_Sound : MonoBehaviour
{
    public AudioClip JumpSE;//�W�����v���ʉ�
    public AudioClip HighJumpSE;// �n�C�W�����v���ʉ�
    public AudioClip SabodonSE;// �T�{�h�����ʉ�
    private bool isJumping = false;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //�X�y�[�X�ŃW�����v
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            audioSource.PlayOneShot(JumpSE);//�W�����v���ʉ�
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")|| collision.gameObject.CompareTag("Elevator"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("Robot"))
        {
            audioSource.PlayOneShot(HighJumpSE);//�n�C�W�����v���ʉ�
        }
        if (collision.gameObject.CompareTag("TogeToge"))
        {
            audioSource.PlayOneShot(SabodonSE);//�T�{�h�����ʉ�
        }

    }

}
