using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Unit_Spawn_Button : MonoBehaviour
{
	public GameObject SpawnUnit;
	public GameObject Wid;


	public void ClickEvent() //Ŭ���� ���� ����
	{
		Instantiate(SpawnUnit, SpawnUnit.transform.position, Quaternion.identity);
	}

	public void ClickWidEvent() //������ Ȱ��ȭ
	{
		Wid.SetActive(true);
		Destroy(this); // �������� ��� �ѹ� ��ȯ�ϸ� ��� ������ �Ǽ� ��ũ��Ʈ�� ��Ȱ��ȭ ���ش�.
	}
}
