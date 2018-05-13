using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// WebService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
[System.Web.Script.Services.ScriptService]//写接口
public class WebService : System.Web.Services.WebService {
    
    public WebService () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }
    
    /// <summary>
    /// 编写接口作用
    /// </summary>
    /// <param name="参数名1"></param>
    /// <param name="参数名2"></param>
    /// <returns></returns>
    [WebMethod]//自动生成
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]//手动添加
    public void sum(int a, int b) // http://localhost:29052/WebService.asmx/sum?a=51&b=22 调用地址
    {
        ArrayList all = new ArrayList();//固定


        all.Add(a + b);//写功能
        

        JavaScriptSerializer serializer = new JavaScriptSerializer();//
        Context.Response.Write(serializer.Serialize(all));//
        Context.Response.End();//固定格式，引包
    }
    
}
