using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AddComponento→Audio→AudioSourceで主人公にAudioSourceをつけてください(AudioClipはNoneで大丈夫です)
public class Hasiru_Sound : MonoBehaviour
{
    public AudioClip JumpSE;//ジャンプ効果音
    public AudioClip HighJumpSE;// ハイジャンプ効果音
    public AudioClip SabodonSE;// サボドン効果音
    private bool isJumping = false;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //スペースでジャンプ
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            audioSource.PlayOneShot(JumpSE);//ジャンプ効果音
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
            audioSource.PlayOneShot(HighJumpSE);//ハイジャンプ効果音
        }
        if (collision.gameObject.CompareTag("TogeToge"))
        {
            audioSource.PlayOneShot(SabodonSE);//サボドン効果音
        }

    }

}
