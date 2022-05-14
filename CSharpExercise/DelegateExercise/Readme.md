# 委派(Delegate)

## 目錄:
- [委派練習1](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BE%E7%B7%B4%E7%BF%921)
- [委派練習2](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BE%E7%B7%B4%E7%BF%922)
- [委派練習3](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BE%E7%B7%B4%E7%BF%923)
- [委派練習4](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BE%E7%B7%B4%E7%BF%924)
- [委派練習5](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BE%E7%B7%B4%E7%BF%925)

## 委派練習1
- [程式碼](https://github.com/LINDuke-Lin/CSharp-Exercise/blob/main/CSharpExercise/DelegateExercise/delegateExercise1.cs)

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

## 委派練習2
- [程式碼](https://github.com/LINDuke-Lin/CSharp-Exercise/blob/main/CSharpExercise/DelegateExercise/delegateExercise2.cs)

1. 新增各種動物
```CSharp
  
	/// <summary>
	/// 貓
	/// </summary>
	public static void Cat()
	{
		Console.WriteLine($"喵喵!");
	}
	
	/// <summary>
	/// 鴨
	/// </summary>
	public static void Duck()
	{
		Console.WriteLine($"呱呱!");
	}
	
	/// <summary>
	/// 雞
	/// </summary>
	public static void Chicken()
	{
		Console.WriteLine($"咕咕!");
	}
```

2. 取消掉委派傳入的名字
```CSharp
    /// <summary>
    /// 定義委派
    /// </summary>
    /// <param name="name">姓名</param>
    private delegate void Animal();

    /// <summary>
    /// 定義函式
    /// </summary>
    /// <param name="animal">動物的委派</param>
    /// <param name="name">動物名字</param>
    private static void RunCircus(Animal animal)
    {
        animal();
    }
```

3. 使用迴圈建立動物List
```CSharp
   List<Animal> deleAnimal = new List<Animal>()
    {
        new Animal(Dog),
        new Animal(Cat),
        new Animal(Duck),
        new Animal(Chicken)
    };
```

4. 使用`foreach`執行馬戲團
```CSharp
	foreach(var animalFunc in deleAnimal)
	{
		RunCircus(animalFunc);
	}
```

[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BEdelegate)

## 委派練習3
### 多點傳送委派(MulticastDelegate)
- [程式碼](https://github.com/LINDuke-Lin/CSharp-Exercise/blob/main/CSharpExercise/DelegateExercise/delegateExercise3.cs)

1. 使用`+=`進行註冊
```CSharp
	Animal deleAnimal = new Animal(Dog);

    deleAnimal += new Animal(Cat);
    deleAnimal += new Animal(Duck);
    deleAnimal += new Animal(Chicken);
```

[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BEdelegate)

## 委派練習4
### Acton 泛型委派
- [程式碼](https://github.com/LINDuke-Lin/CSharp-Exercise/blob/main/CSharpExercise/DelegateExercise/delegateExercise4.cs)

1. 定義函式
- 傳入值設定為 Action
- Action -> 可以直接傳入函式
```CSharp
	/// <summary>
    /// 定義函式
    /// </summary>
    /// <param name="animal">動物的委派</param>
    private static void RunCircus(Action animal)
    {
        animal();
    }
```

2. 呼叫馬戲團
- 直接傳入狗函式
- 無須做任何實例化
```CSharp
 RunCircus(Dog);
```

[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BEdelegate)

## 委派練習5
### Acton 泛型委派 - 傳參數
- [程式碼](https://github.com/LINDuke-Lin/CSharp-Exercise/blob/main/CSharpExercise/DelegateExercise/delegateExercise4.cs)

1. 定義函式
- 傳入值設定為 Action<string>
- <T> 之中帶入要傳遞的變數型別
- Action -> 可以直接傳入函式
```CSharp
    /// <summary>
    /// 定義函式
    /// </summary>
    /// <param name="animal">動物的委派</param>
    private static void RunCircus(Action<string> animal, string name)
    {
        animal(name);
    }
```

2. 呼叫馬戲團
- 直接傳入狗函式
- 無須做任何實例化
```CSharp
 RunCircus(Dog, "狗狗");
```

[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/main/CSharpExercise/DelegateExercise#%E5%A7%94%E6%B4%BEdelegate)