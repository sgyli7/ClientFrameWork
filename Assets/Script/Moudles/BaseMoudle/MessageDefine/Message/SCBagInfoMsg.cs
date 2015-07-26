/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NetFramework.Auto
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SCBagInfoMsg : TBase
  {
    private List<NetFramework.Auto.PropsInfo> _propsInfoList;
    private List<NetFramework.Auto.HeroInfo> _heroInfoList;
    private List<NetFramework.Auto.HeroEquipmentInfo> _heroEquipmentInfoList;
    private List<NetFramework.Auto.CharEquipmentInfo> _charBodyEquipmentInfoList;
    private List<NetFramework.Auto.GemInfo> _gemInfoList;

    public List<NetFramework.Auto.PropsInfo> PropsInfoList
    {
      get
      {
        return _propsInfoList;
      }
      set
      {
        __isset.propsInfoList = true;
        this._propsInfoList = value;
      }
    }

    public List<NetFramework.Auto.HeroInfo> HeroInfoList
    {
      get
      {
        return _heroInfoList;
      }
      set
      {
        __isset.heroInfoList = true;
        this._heroInfoList = value;
      }
    }

    public List<NetFramework.Auto.HeroEquipmentInfo> HeroEquipmentInfoList
    {
      get
      {
        return _heroEquipmentInfoList;
      }
      set
      {
        __isset.heroEquipmentInfoList = true;
        this._heroEquipmentInfoList = value;
      }
    }

    public List<NetFramework.Auto.CharEquipmentInfo> CharBodyEquipmentInfoList
    {
      get
      {
        return _charBodyEquipmentInfoList;
      }
      set
      {
        __isset.charBodyEquipmentInfoList = true;
        this._charBodyEquipmentInfoList = value;
      }
    }

    public List<NetFramework.Auto.GemInfo> GemInfoList
    {
      get
      {
        return _gemInfoList;
      }
      set
      {
        __isset.gemInfoList = true;
        this._gemInfoList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool propsInfoList;
      public bool heroInfoList;
      public bool heroEquipmentInfoList;
      public bool charBodyEquipmentInfoList;
      public bool gemInfoList;
    }

    public SCBagInfoMsg() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                PropsInfoList = new List<NetFramework.Auto.PropsInfo>();
                TList _list32 = iprot.ReadListBegin();
                for( int _i33 = 0; _i33 < _list32.Count; ++_i33)
                {
                  NetFramework.Auto.PropsInfo _elem34 = new NetFramework.Auto.PropsInfo();
                  _elem34 = new NetFramework.Auto.PropsInfo();
                  _elem34.Read(iprot);
                  PropsInfoList.Add(_elem34);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                HeroInfoList = new List<NetFramework.Auto.HeroInfo>();
                TList _list35 = iprot.ReadListBegin();
                for( int _i36 = 0; _i36 < _list35.Count; ++_i36)
                {
                  NetFramework.Auto.HeroInfo _elem37 = new NetFramework.Auto.HeroInfo();
                  _elem37 = new NetFramework.Auto.HeroInfo();
                  _elem37.Read(iprot);
                  HeroInfoList.Add(_elem37);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                HeroEquipmentInfoList = new List<NetFramework.Auto.HeroEquipmentInfo>();
                TList _list38 = iprot.ReadListBegin();
                for( int _i39 = 0; _i39 < _list38.Count; ++_i39)
                {
                  NetFramework.Auto.HeroEquipmentInfo _elem40 = new NetFramework.Auto.HeroEquipmentInfo();
                  _elem40 = new NetFramework.Auto.HeroEquipmentInfo();
                  _elem40.Read(iprot);
                  HeroEquipmentInfoList.Add(_elem40);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                CharBodyEquipmentInfoList = new List<NetFramework.Auto.CharEquipmentInfo>();
                TList _list41 = iprot.ReadListBegin();
                for( int _i42 = 0; _i42 < _list41.Count; ++_i42)
                {
                  NetFramework.Auto.CharEquipmentInfo _elem43 = new NetFramework.Auto.CharEquipmentInfo();
                  _elem43 = new NetFramework.Auto.CharEquipmentInfo();
                  _elem43.Read(iprot);
                  CharBodyEquipmentInfoList.Add(_elem43);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                GemInfoList = new List<NetFramework.Auto.GemInfo>();
                TList _list44 = iprot.ReadListBegin();
                for( int _i45 = 0; _i45 < _list44.Count; ++_i45)
                {
                  NetFramework.Auto.GemInfo _elem46 = new NetFramework.Auto.GemInfo();
                  _elem46 = new NetFramework.Auto.GemInfo();
                  _elem46.Read(iprot);
                  GemInfoList.Add(_elem46);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SCBagInfoMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PropsInfoList != null && __isset.propsInfoList) {
        field.Name = "propsInfoList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PropsInfoList.Count));
          foreach (NetFramework.Auto.PropsInfo _iter47 in PropsInfoList)
          {
            _iter47.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (HeroInfoList != null && __isset.heroInfoList) {
        field.Name = "heroInfoList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, HeroInfoList.Count));
          foreach (NetFramework.Auto.HeroInfo _iter48 in HeroInfoList)
          {
            _iter48.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (HeroEquipmentInfoList != null && __isset.heroEquipmentInfoList) {
        field.Name = "heroEquipmentInfoList";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, HeroEquipmentInfoList.Count));
          foreach (NetFramework.Auto.HeroEquipmentInfo _iter49 in HeroEquipmentInfoList)
          {
            _iter49.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (CharBodyEquipmentInfoList != null && __isset.charBodyEquipmentInfoList) {
        field.Name = "charBodyEquipmentInfoList";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, CharBodyEquipmentInfoList.Count));
          foreach (NetFramework.Auto.CharEquipmentInfo _iter50 in CharBodyEquipmentInfoList)
          {
            _iter50.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (GemInfoList != null && __isset.gemInfoList) {
        field.Name = "gemInfoList";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, GemInfoList.Count));
          foreach (NetFramework.Auto.GemInfo _iter51 in GemInfoList)
          {
            _iter51.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCBagInfoMsg(");
      sb.Append("PropsInfoList: ");
      sb.Append(PropsInfoList);
      sb.Append(",HeroInfoList: ");
      sb.Append(HeroInfoList);
      sb.Append(",HeroEquipmentInfoList: ");
      sb.Append(HeroEquipmentInfoList);
      sb.Append(",CharBodyEquipmentInfoList: ");
      sb.Append(CharBodyEquipmentInfoList);
      sb.Append(",GemInfoList: ");
      sb.Append(GemInfoList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
