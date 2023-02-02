using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Unit_Spawn_Button : MonoBehaviour
{
	public GameObject SpawnUnit;
	public GameObject Wid;


	public void ClickEvent() //클릭시 유닛 생성
	{
		Instantiate(SpawnUnit, SpawnUnit.transform.position, Quaternion.identity);
	}

	public void ClickWidEvent() //마법사 활성화
	{
		Wid.SetActive(true);
		Destroy(this); // 마법사의 경우 한번 소환하면 계속 유지가 되서 스크립트를 비활성화 해준다.
	}
}
