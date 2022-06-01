using UnityEngine;

    //MonoBehaviour

public class LearnMethod : MonoBehaviour
{
    private void Start()
    {
        // 呼叫方法
        // 方法名稱()
        Test();
        PrintColorText();
    }
    // 方法語法
    // 傳回類型 方法自訂名稱(){方法內容}
    // 無傳回void
    // 方法名稱unity習慣用大寫開頭
    private void Test()
    {
        //輸出(內容)
        print("hello world");
    }
    // 自訂方法
    // 需要呼叫才會執行

    // unity的入口
    // 開始事件
    // 播放遊戲後會執行一次
    // 初始化設定: 初始金額 三條命等等
    private void PrintColorText()
    {
        print( "<color=yellow>黃色訊息</color>" );
        print( "<color=red>red訊息</color>" );
        print( "<color=#003399>藍色訊息</color>" );

    }
}
