//單行註解，說明，標記 zairan 2022.05.16
/*
 * 多行註解
 * 多註解
 */

// 藍色 保留字
// 白色 名稱
// 綠色 資料類型

using UnityEngine;

// 修飾詞 類別(藍圖) 類別名稱 繼承(物件導向設計 oop 三大原則)
public class Learndata : MonoBehaviour
{
    //LearmData 類別成員區域
    // 欄位 field
    // 儲存各種資料
    // 資料類型 欄位自訂名稱 結束符號
    // 定義一筆整數資料 名稱叫做 hp
    int hp ;

    // 資料類型:四大基本類型
    // 整數 : 保存正負沒有小數點的資料 int
    // 福點數 : 保存正負有小數點的資料 float
    // 字串 : 保存文字資訊 string
    // 布林值 : 保存有 沒有 bool

    int lv = 87;
    float exp = 0.003f;
    string playername = "201902@ff";
    bool hasCureSkill = false ;
    // bool has "true" or "false" two string

}
//LearmData 非類別成員區域