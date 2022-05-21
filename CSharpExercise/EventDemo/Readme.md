# Event(事件)

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