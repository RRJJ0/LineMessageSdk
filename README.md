# LineMessageSdk

ASP.NET Core 8 Web Api 建構 [Line Message Api](https://developers.line.biz/en/docs/messaging-api/overview/) Library  
基於 [WebHook Receive Event](https://developers.line.biz/en/reference/messaging-api/#webhook-event-objects) 跟 [Send Message Object](https://developers.line.biz/en/reference/messaging-api/#message-objects)  Model  

**Current Function**
- [x] push
- [x] broadcast
- [x] multicast
- [ ] other....

## 目錄
- [環境](#環境)
- [安裝](#安裝)
- [使用方式](#使用方式)

## 環境
ASP.NET Core 8 

## 安裝
// To be continue

## 使用方式 
### Receive 
1. 在 Program.cs 調整 AddControllers()，將 [Reviece Message](https://developers.line.biz/en/docs/messaging-api/receiving-messages/) 的 Webhook 加入到專案內  

```csharp
builder.Services.AddControllers().AddApplicationPart(typeof(LineController).Assembly);
```
發佈後的路徑 
```
https://{your base address}/Line/Receive
```  
2. 建立YourMessageReciever類別並繼承 IMessageReceiver。   
channelSercet 填寫自己 Line bot 的，在 Verify signature 會需要用到。  
收到不同事件的時候會進入到各個不同[事件](https://developers.line.biz/en/reference/messaging-api/#webhook-event-objects)的 CallBack
```csharp 
namespace Test
{
  public class YourMessageReceiver : IMessageReceiver
  {
    public string GetChannelSercet()
    {
        return "Your Line Channel Sercet";
    }
  
    public void OnTextMessage(MessageEvent ev, TextMessage message)
    {
      // Do something
    }
    //... other callback 
}
```

3. 在 Program.cs 依賴注入 YourMessageReciever
```csharp
builder.Services.AddSingleton<IMessageReceiver, YourMessageReceiver>(); 
```

### Send

```csharp
var messager = new LineMessager("your channel token");
List<Message> messageList = new ()
{
  new TextMessage()
  {
      text = $"This is a Test Message"
  }
};
messager.Push(messages: messageList, to: "userId or groupId or roomId")
```
跟Receiver組合
```csharp
using Send = Line.Model.Send.Message;

namespace Test
{
  public class YourMessageReceiver : IMessageReceiver
  {
    private string channelToken = "your channel token";
    private LineMessager messager;
    public YourMessageReceiver()
    {
      messager = new LineMessager(channelToken);
    }
    public string GetChannelSercet()
    {
        return "Your Line Channel Sercet";
    }
  
    public void OnTextMessage(MessageEvent ev, TextMessage message)
    {
      // DO your work
      var msgList = new List<Send.Message>() 
      {
        new Send.TextMessage()
        {
          text = $"This is a Test Message"
        }
      };
      messager.Push(messages: msgList, to: ev.source.userId);
    }
    //... other callback 
}
```

