//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using SimpleJSON;

namespace LubanConfig
{
   
public sealed partial class Tables
{
    public DataTable.TbItem TbItem {get; }
    public DataTable.TbGameConfig TbGameConfig {get; }
    public DataTable.TbUIConfig TbUIConfig {get; }
    public DataTable.TbSceneConfig TbSceneConfig {get; }

    public System.Collections.Generic.Dictionary<string, object> Table {get; private set;}

    public Tables(System.Func<string, JSONNode> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbItem = new DataTable.TbItem(loader("datatable_tbitem")); 
        tables.Add("DataTable.TbItem", TbItem);
        TbGameConfig = new DataTable.TbGameConfig(loader("datatable_tbgameconfig")); 
        tables.Add("DataTable.TbGameConfig", TbGameConfig);
        TbUIConfig = new DataTable.TbUIConfig(loader("datatable_tbuiconfig")); 
        tables.Add("DataTable.TbUIConfig", TbUIConfig);
        TbSceneConfig = new DataTable.TbSceneConfig(loader("datatable_tbsceneconfig")); 
        tables.Add("DataTable.TbSceneConfig", TbSceneConfig);
        PostInit();

        TbItem.Resolve(tables); 
        TbGameConfig.Resolve(tables); 
        TbUIConfig.Resolve(tables); 
        TbSceneConfig.Resolve(tables); 
        PostResolve();

        Table = new System.Collections.Generic.Dictionary<string, object>(tables);
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbItem.TranslateText(translator); 
        TbGameConfig.TranslateText(translator); 
        TbUIConfig.TranslateText(translator); 
        TbSceneConfig.TranslateText(translator); 
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}