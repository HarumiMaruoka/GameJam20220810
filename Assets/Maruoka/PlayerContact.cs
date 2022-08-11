using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary> Playerの接触処理を担当するクラス </summary>
public class PlayerContact : MonoBehaviour
{
    // ************** メンバー変数 ************** //
    [Header("障害物オブジェクトのタグの名前"), SerializeField] string _obstacleTagName;
    [Header("スコアアイテムのタグの名前"), SerializeField] string _scoreItemTagName;
    [Header("ゴールオブジェクトのタグの名前"), SerializeField] string _gaolObjectTagName;
    [Header("回復アイテムのタグの名前"), SerializeField] string _healItemTagName;
    [Header("リザルトシーンの名前"), SerializeField] string _resultSceneName;

    [Header("現在のヒットポイント"), SerializeField] public int _hitPoint;
    [Header("最初のヒットポイント"), SerializeField] public int _firstHitPoint;
    [Header("ゴッドモード"), SerializeField] bool _isGodMode;

    [Header("エネミーヒット後のゴッドモード時間"), SerializeField] float _godModeTime;
    [Header("スコアアイテム取得時のスコア"), SerializeField] int _scoreItemsScore;

    private void Start()
    {
        _hitPoint = _firstHitPoint;
        Debug.Log("dskljfdl");
    }

    private void OnEnable()
    {
        
    }

    // 何かに衝突したときに呼ばれるメッセージ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Tagで判定する。
        // 障害物接触を判定する
        if (collision.gameObject.tag == _obstacleTagName)
        {
            //ゴッドモードでなければダメージを受ける
            if (!_isGodMode)
            {
                StartCoroutine(Start_GodMode());
                _hitPoint--;

                //体力が0以下であればリザルトシーンへ移行
                if (_hitPoint <= 0)
                {
                    SceneManager.LoadScene(_resultSceneName);
                }
            }
        }
    }

    // 何かに接触したら呼ばれるメッセージ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tagで判定する。
        // スコアアイテムに接触したらスコアを加算
        if (collision.tag == _scoreItemTagName)
        {
            Destroy(collision.gameObject);
            ScoreManager._score += _scoreItemsScore;
        }
        // 回復アイテムと接触した時の処理
        else if (collision.tag == _healItemTagName)
        {
            Destroy(collision.gameObject);
            _hitPoint++;
        }
        // ゴールに接触したらリザルトシーンへ移行する
        else if (collision.tag == _gaolObjectTagName)
        {
            SceneManager.LoadScene(_resultSceneName);
        }
    }

    /// <summary>  </summary>
    /// <returns></returns>
    IEnumerator Start_GodMode()
    {
        _isGodMode = true;
        yield return new WaitForSeconds(_godModeTime);
        _isGodMode = false;
    }
}
