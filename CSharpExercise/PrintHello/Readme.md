# 練習1: 將輸入n 印出 Hello 圖型

## 題目:
請寫一程式可以輸入列數n，第一列印出`n + 5`個字，以後每列遞減 1 個字。內容以`Hello`字串依序取出字來填入，已產生如下列圖形
(以`n = 6`為例)

```
HelloHelloH
elloHelloH
elloHello
HelloHel
loHello
HelloH
```

### 版本1

- [程式碼](https://github.com/LINDuke-Lin/CSharp-Exercise/blob/main/CSharpExercise/PrintHello/PrintHello1.cs)

1. 定義 Hello 陣列

```Csharp
 // 定義要印的陣列
 private string[] StrAry = new string[] { "H", "e", "l", "l", "o" };
```

2. 將 n + 5

```Csharp
int total = n + 5;
```

3. 使用取餘的方式計算正確的文字

```Csharp
//取餘
Console.Write(StrAry[tempCount % 5]);
```

4. 使用迴圈印出圖形

```Csharp
//取餘
 // 紀錄當前的數字
 int tempCount = 0;

 // 開始排序
 for (int i = total; i > 5; i--)
 {
     // 印出每行的文字
     for (int j = 0; j < i; j++)
     {
         //取餘
         Console.Write(StrAry[tempCount % 5]);
         tempCount++;
     }
     // 換下一行
     Console.WriteLine();
 }
```