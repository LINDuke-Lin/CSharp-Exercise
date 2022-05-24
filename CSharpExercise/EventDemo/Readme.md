# Event(事件)

## 目錄:
- [事件練習1 - delegate & event](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/origin/chicken/CSharpExercise/EventDemo#%E4%BA%8B%E4%BB%B6%E7%B7%B4%E7%BF%921)
- [事件練習2 - 泛型委派(Action)](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/origin/chicken/CSharpExercise/EventDemo#%E4%BA%8B%E4%BB%B6%E7%B7%B4%E7%BF%922---%E6%B3%9B%E5%9E%8B%E5%A7%94%E6%B4%BEaction)


## 事件練習1
- `delegate` & `event`

### 一.狗類別 - 事件發送者
1. 宣告事件使用的委派

```CSharp
    /// <summary>
    /// 事件委派
    /// </summary>
    /// <param name="sander"></param>
    /// <param name="e"></param>
    public delegate void AnimalEventHandler(object sander, EventArgs e);
```
`!!!事件的委派命名規則習慣以 EventHandler 結尾`

2. 宣告事件

```CSharp
	/// <summary>
	/// 定義事件
	/// </summary>
	public event AnimalEventHandler Alarm;
```

3. 觸發事件的函式

```CSharp
	/// <summary>
	/// 觸發事件
	/// </summary>
	public void OnAlarm()
	{
	    if (this.Alarm != null)
	    {
	        Console.WriteLine("汪汪!");
	        this.Alarm(this, new EventArgs());
	    }
	}
```
### 二. Host類別 - 事件接收者
1. 事件處理函式

```CSharp
	/// <summary>
	/// 事件處理
	/// </summary>
	/// <param name="sander"></param>
	/// <param name="e"></param>
	public void HostHandleAlam(object sander, EventArgs e)
	{
	    Console.WriteLine("抓住小偷了!");
	}
```

2. 註冊事件
- 註冊事件需使用 `+=` 符號
- 此處使用建構子來做事件註冊

```CSharp
	/// <summary>
	/// 註冊事件
	/// </summary>
	/// <param name="dog"></param>
	public Host(Dog dog)
	{
	    dog.Alarm += new Dog.AnimalEventHandler(HostHandleAlam);
	}
```

### 三. 主程式

```CSharp
	/// <summary>
	/// 主程式
	/// </summary>
	public void Main()
	{
	    // 1. 實例化 狗類別
	    Dog dog = new Dog();
	    // 2. 實例化 事件接收者
	    Host host = new Host(dog);
	
	    // 3. 事件觸發
	    dog.OnAlarm();
	}
```


[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/origin/chicken/CSharpExercise/EventDemo#event%E4%BA%8B%E4%BB%B6)

## 事件練習2 - 泛型委派(Action)
- `Action` & `event`

1. 宣告事件
- 此處加上泛型委派，就無須另外宣告`delegate`
```CSharp
   /// <summary>
   /// 貓咪泛型事件
   /// </summary>
   public event Action AnimalEventHandler;
```

2. 實現觸發事件的函式
- 使用`?.Invoke();`
```CSharp
	/// <summary>
	/// 貓咪函式
	/// </summary>
	public void OnAlarm()
	{
	    Console.WriteLine("喵喵");
	    AnimalEventHandler?.Invoke();
	}
```

3. 實作CatHost類別
- 將貓類別由建構子注入
- 並註冊事件
- 實現事件的函式
```CSharp
    public class CatHost
    {
        /// <summary>
        /// 建構子注入貓咪 並註冊事件
        /// </summary>
        /// <param name="cat"></param>
        public CatHost(Cat cat)
        {
            cat.AnimalEventHandler += new Action(AlarmHandler);
        }

        /// <summary>
        /// 事件處理
        /// </summary>
        public void AlarmHandler()
        {
            Console.WriteLine("貓來了");
        }
    }
```

4. 主程式
```CSharp
	public void Main()
	{
	    Cat cat = new Cat();
	    CatHost catHost = new CatHost(cat);
	
	    cat.OnAlarm();
	}
```


[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/origin/chicken/CSharpExercise/EventDemo#event%E4%BA%8B%E4%BB%B6)

## 事件練習3 - 泛型委派(Action) - 匿名函式

- 註冊時使用匿名函式實作
```CSharp
	/// <summary>
	/// 以建構子注入鴨類別，並以匿名函式實作
	/// </summary>
	/// <param name="duck"></param>
	public DuckHost(Duck duck)
	{
	    //此處使用匿名函數
	    duck.AnimalEventHandler += new Action(() => { Console.WriteLine("變烤鴨了"); });
	}
```

[回頁首](https://github.com/LINDuke-Lin/CSharp-Exercise/tree/origin/chicken/CSharpExercise/EventDemo#event%E4%BA%8B%E4%BB%B6)