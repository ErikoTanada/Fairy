using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤーを制御するコンポーネント
public class Player : MonoBehaviour
{
    public float m_speed; // 移動の速さ
	
	// 毎フレーム呼び出される関数
	private void Update()
	{
	    // ゲームを 60 FPS に固定する
		Application.targetFrameRate = 60;
		
		// 矢印キーの入力情報を取得する
		var h = Input.GetAxis( "Horizontal" );
		var v = Input.GetAxis( "Vertical" );
		
		// 矢印キーが押されている方向にプレイヤーを移動する
		var velocity = new Vector3( h, v ) * m_speed;
		transform.localPosition += velocity;
		
		// プレイヤーが画面外に出ないように位置を制限する
		transform.localPosition = Utils.
		ClampPosition( transform.localPosition );
	}
}
