using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sabodon : MonoBehaviour
{
	[SerializeField]
	[Tooltip("�L�[���͂𖳌��ɂ���b��")]
	private float disableKeyInputSeconds;
	public static Sabodon instance;
	public bool isTogeDamege;
	public void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}
	void Start()
	{
		isTogeDamege = true;
	}
    private void OnCollisionEnter(Collision collision)
	{
		// �������������"TogeToge"�^�O���t���Ă���ꍇ
		if (collision.gameObject.tag == "TogeToge")
		{
			// �R���[�`�����J�n
			StartCoroutine("DisableKeyInputCoroutine");
			
		}
	}

	private IEnumerator DisableKeyInputCoroutine()
	{
		Debug.Log("�g�Q�g�Q");
		GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
		// �ړ�����
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = false;
		isTogeDamege = false;
		//���Ԓ�~�\�͖���
		//Hasiru1.gameObject.GetComponent<StopAbility>().enabled = false;
		// �A�j���[�V��������
		//Hasiru1.gameObject.GetComponent<Hasiru_Animation>().enabled = false;

		// �w�肵���b���҂�
		yield return new WaitForSeconds(disableKeyInputSeconds);
		Debug.Log("�g�Q�g�Q�I��");
		//�ړ������ɖ߂�
		Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = true;
		isTogeDamege = true;
		//���Ԓ�~�\�͗L��
		//Hasiru1.gameObject.GetComponent<StopAbility>().enabled = true;
		// �A�j���[�V���������ɖ߂�
		//Hasiru1.gameObject.GetComponent<Hasiru_Animation>().enabled = true;
	}
}
