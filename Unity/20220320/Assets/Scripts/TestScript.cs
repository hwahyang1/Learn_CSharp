using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
	/* {EditorPath}\{Version}\Editor\Data\Resources\ScriptTemplates 에서 템플릿 수정 가능 */

	/* 유니티에서 한글 인코딩 깨지면
	 * 프로젝트 우클릭 -> (추가 -> 새 항목 -> (텍스트 파일 -> .editorconfig)) -> (보기 탭 -> 코드) -> (파일 참고) -> 스크립트 다른 이름으로 저장 -> 저장 옆에 드롭다운 -> 인코딩하여 저장 -> 대치 -> 인코딩 65001
	 */

	/* 공통 호출 조건: 게임이 실행 상태여야 함! */

	// Script 로딩 직후 호출
	private void Awake()
	{
		Debug.Log("Awake()");
	}

	// 엮여있는 Object가 준비되면 호출
	private void OnEnable()
	{
		Debug.Log("OnEnable()");
	}

	// Script 시작되면 호출
	private void Start()
	{
		Debug.Log("Start()");
	}

	// 신뢰할 수 있는 타이머(0.02초, Project Settings에서 Time탭 확인)를 기준으로 호출 (규칙적)
	private void FixedUpdate()
	{
		Debug.Log("FixedUpdate()");
	}
	// 프레임마다 호출 (불규칙적)
	private void Update()
	{
		Debug.Log("Update()");
	}
	// 얘는 3인칭 카메라 쓸 때 많이 쓰임 (위보다 조금 늦게 호출)
	private void LateUpdate()
	{
		Debug.Log("LateUpdate()");
	}

	// 비활성화 되면 호출
	private void OnDisable()
	{
		Debug.Log("OnDisable()");
	}

	// 삭제 직전 호출
	private void OnDestroy()
	{
		Debug.Log("OnDestroy()");
	}
}
