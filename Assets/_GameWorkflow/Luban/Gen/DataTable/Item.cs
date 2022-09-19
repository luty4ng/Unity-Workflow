//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace LubanConfig.DataTable
{

public sealed partial class Item :  Bright.Config.BeanBase, System.ICloneable 
{
    public Item(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["zh_name"].IsString) { throw new SerializationException(); }  ZhName = _json["zh_name"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { if(!_json["type"].IsNumber) { throw new SerializationException(); }  Type = (ItemEnum.ItemType)_json["type"].AsInt; }
        { if(!_json["price"].IsNumber) { throw new SerializationException(); }  Price = _json["price"]; }
        { if(!_json["max_overlap"].IsNumber) { throw new SerializationException(); }  MaxOverlap = _json["max_overlap"]; }
        { if(!_json["upgrade_to_item_id"].IsNumber) { throw new SerializationException(); }  UpgradeToItemId = _json["upgrade_to_item_id"]; }
        { if(!_json["icon"].IsString) { throw new SerializationException(); }  Icon = _json["icon"]; }
        { if(!_json["close_up"].IsString) { throw new SerializationException(); }  CloseUp = _json["close_up"]; }
        { if(!_json["can_interact"].IsBoolean) { throw new SerializationException(); }  CanInteract = _json["can_interact"]; }
        { if(!_json["color"].IsNumber) { throw new SerializationException(); }  Color = (ItemEnum.HighLightColor)_json["color"].AsInt; }
        { var __json0 = _json["interact_callback"]; if(!__json0.IsArray) { throw new SerializationException(); } InteractCallback = new System.Collections.Generic.List<ItemBean.InteractCallback>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ItemBean.InteractCallback __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ItemBean.InteractCallback.DeserializeInteractCallback(__e0); }  InteractCallback.Add(__v0); }   }
        PostInit();
    }

    public Item(int id, string name, string zh_name, string desc, ItemEnum.ItemType type, int price, int max_overlap, int upgrade_to_item_id, string icon, string close_up, bool can_interact, ItemEnum.HighLightColor color, System.Collections.Generic.List<ItemBean.InteractCallback> interact_callback ) 
    {
        this.Id = id;
        this.Name = name;
        this.ZhName = zh_name;
        this.Desc = desc;
        this.Type = type;
        this.Price = price;
        this.MaxOverlap = max_overlap;
        this.UpgradeToItemId = upgrade_to_item_id;
        this.Icon = icon;
        this.CloseUp = close_up;
        this.CanInteract = can_interact;
        this.Color = color;
        this.InteractCallback = interact_callback;
        PostInit();
    }

    public static Item DeserializeItem(JSONNode _json)
    {
        return new DataTable.Item(_json);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string ZhName { get; private set; }
    public string Desc { get; private set; }
    public ItemEnum.ItemType Type { get; private set; }
    public int Price { get; private set; }
    public int MaxOverlap { get; private set; }
    /// <summary>
    /// 用于检查引用完整性
    /// </summary>
    public int UpgradeToItemId { get; private set; }
    public DataTable.Item UpgradeToItemId_Ref { get; private set; }
    public string Icon { get; private set; }
    public string CloseUp { get; private set; }
    public bool CanInteract { get; private set; }
    public ItemEnum.HighLightColor Color { get; private set; }
    /// <summary>
    /// DIALOG/TIPS/CLOSEUP/BUBBLE/TIMELINE/GETCARDS
    /// </summary>
    public System.Collections.Generic.List<ItemBean.InteractCallback> InteractCallback { get; private set; }

    public const int __ID__ = 1612032189;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.UpgradeToItemId_Ref = (_tables["DataTable.TbItem"] as DataTable.TbItem).GetOrDefault(UpgradeToItemId);
        foreach(var _e in InteractCallback) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in InteractCallback) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "ZhName:" + ZhName + ","
        + "Desc:" + Desc + ","
        + "Type:" + Type + ","
        + "Price:" + Price + ","
        + "MaxOverlap:" + MaxOverlap + ","
        + "UpgradeToItemId:" + UpgradeToItemId + ","
        + "Icon:" + Icon + ","
        + "CloseUp:" + CloseUp + ","
        + "CanInteract:" + CanInteract + ","
        + "Color:" + Color + ","
        + "InteractCallback:" + Bright.Common.StringUtil.CollectionToString(InteractCallback) + ","
        + "}";
    }

    public object Clone()
    {
        return new Item(this.Id, this.Name, this.ZhName, this.Desc, this.Type, this.Price, this.MaxOverlap, this.UpgradeToItemId, this.Icon, this.CloseUp, this.CanInteract, this.Color, this.InteractCallback);
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
