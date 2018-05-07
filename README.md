# UConfig
基于Unity的可视化配置文件工具

---

## 简介
在游戏开发中,我们经常要对一些数据预先配置,比如不同角色的属性,武器的各项数值等等,一般可通过XML配置. 此外还可以用Unity自带的.Asset资源配置文件配置数据,下面介绍一下如何灵活快速的创建.Asset文件并使用.

相比XML配置文件, Asset文件更加直观而且支持直接配置如 GameObject、Sprite、AudioClip等更加高级的对象,基本上除了接口、事件 都可以通过Asset文件配置 , 所以说灵活性上比XML要更强一点.

UConfig的优势在于通过ScriptableObject.CreateInstance的反射机制能够快速的创建.Asset文件，并且提供了友好的编辑器UI界面，使用简单.

## 插件演示

- 首先创建一个继承于ScriptableObject 类的对象

```
[System.Serializable]
public class DemoConfig : ScriptableObject {

    public string userName;

    public int userID;

    public GameObject userObject;

    public Sprite sprite;

    public AudioClip audioClip;

    public void print() {
        Debug.Log(string.Format("name: {0} id: {1}" , userName , userID));
    }
}
```

- 使用UConfig创建对应的Asset文件

![创建Asset配置文件](https://fold.oss-cn-shanghai.aliyuncs.com/BlogImg/UConfig%E9%85%8D%E7%BD%AE/Config%E9%85%8D%E7%BD%AE.gif)

![创建成功](https://fold.oss-cn-shanghai.aliyuncs.com/BlogImg/UConfig%E9%85%8D%E7%BD%AE/UConfig3.png)

- 配置各项属性
![配置属性](https://fold.oss-cn-shanghai.aliyuncs.com/BlogImg/UConfig%E9%85%8D%E7%BD%AE/%E8%AE%BE%E7%BD%AE%E9%85%8D%E7%BD%AE%E6%96%87%E4%BB%B6.gif)

以上就是创建Asset资源配置文件的流程，是不是极度简单，如有帮助到大家请点个star ^_^
