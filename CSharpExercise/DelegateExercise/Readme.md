# 委派(Delegate)

## 目錄:
- [委派練習1](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BE%E7%B7%B4%E7%BF%921)

## 委派練習1

1. 定義要使用的委派
- 使用`delegate`關鍵字
- 定義傳入參數`string name`

```CSharp
    /// <summary>
    /// 定義委派
    /// </summary>
    /// <param name="name">姓名</param>
    private delegate void Animal(string name);
```

2. 定義要接收委派的函式
- 定義馬戲團表演的函式
- 傳入委派與動物姓名
- 在函式裡實現委派`animal(name);`
```CSharp
    /// <summary>
    /// 定義函式
    /// </summary>
    /// <param name="animal">動物的委派</param>
    /// <param name="name">動物名字</param>
    private static void RunCircus(Animal animal, string name)
    {
        animal(name);
    }
```

3. 定義小狗函式
```CSharp
    /// <summary>
    /// 小狗函式
    /// </summary>
    /// <param name="name">姓名</param>
    private static void Dog(string name)
    {
        Console.WriteLine($"汪汪! 我是{name}");
    }
```

4. 在主程式實例化動物委派
- 將小狗作為函式帶入
```CSharp
   Animal deleDog = new Animal(Dog);
```

5. 將呼叫馬戲團函式
- 將動物委派傳入
```CSharp
  RunCircus(deleDog, "小狗");
```

[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BEdelegate)