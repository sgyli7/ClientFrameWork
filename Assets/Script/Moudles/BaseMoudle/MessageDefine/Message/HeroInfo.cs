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
  public partial class HeroInfo : TBase
  {
    private int _templateId;
    private long _uniqueId;
    private short _level;
    private int _exp;
    private sbyte _star;
    private sbyte _quality;
    private List<SkillInfo> _skillInfoList;
    private int _loyalty;

    /// <summary>
    /// 英雄ID
    /// </summary>
    public int TemplateId
    {
      get
      {
        return _templateId;
      }
      set
      {
        __isset.templateId = true;
        this._templateId = value;
      }
    }

    public long UniqueId
    {
      get
      {
        return _uniqueId;
      }
      set
      {
        __isset.uniqueId = true;
        this._uniqueId = value;
      }
    }

    public short Level
    {
      get
      {
        return _level;
      }
      set
      {
        __isset.level = true;
        this._level = value;
      }
    }

    public int Exp
    {
      get
      {
        return _exp;
      }
      set
      {
        __isset.exp = true;
        this._exp = value;
      }
    }

    public sbyte Star
    {
      get
      {
        return _star;
      }
      set
      {
        __isset.star = true;
        this._star = value;
      }
    }

    public sbyte Quality
    {
      get
      {
        return _quality;
      }
      set
      {
        __isset.quality = true;
        this._quality = value;
      }
    }

    public List<SkillInfo> SkillInfoList
    {
      get
      {
        return _skillInfoList;
      }
      set
      {
        __isset.skillInfoList = true;
        this._skillInfoList = value;
      }
    }

    /// <summary>
    /// 0为没有编组，1-3为编组ID
    /// </summary>
    public int Loyalty
    {
      get
      {
        return _loyalty;
      }
      set
      {
        __isset.loyalty = true;
        this._loyalty = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool templateId;
      public bool uniqueId;
      public bool level;
      public bool exp;
      public bool star;
      public bool quality;
      public bool skillInfoList;
      public bool loyalty;
    }

    public HeroInfo() {
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
          case 10:
            if (field.Type == TType.I32) {
              TemplateId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I64) {
              UniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I16) {
              Level = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.I32) {
              Exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.Byte) {
              Star = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 60:
            if (field.Type == TType.Byte) {
              Quality = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 70:
            if (field.Type == TType.List) {
              {
                SkillInfoList = new List<SkillInfo>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  SkillInfo _elem2 = new SkillInfo();
                  _elem2 = new SkillInfo();
                  _elem2.Read(iprot);
                  SkillInfoList.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 100:
            if (field.Type == TType.I32) {
              Loyalty = iprot.ReadI32();
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
      TStruct struc = new TStruct("HeroInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.templateId) {
        field.Name = "templateId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TemplateId);
        oprot.WriteFieldEnd();
      }
      if (__isset.uniqueId) {
        field.Name = "uniqueId";
        field.Type = TType.I64;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(UniqueId);
        oprot.WriteFieldEnd();
      }
      if (__isset.level) {
        field.Name = "level";
        field.Type = TType.I16;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Level);
        oprot.WriteFieldEnd();
      }
      if (__isset.exp) {
        field.Name = "exp";
        field.Type = TType.I32;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exp);
        oprot.WriteFieldEnd();
      }
      if (__isset.star) {
        field.Name = "star";
        field.Type = TType.Byte;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Star);
        oprot.WriteFieldEnd();
      }
      if (__isset.quality) {
        field.Name = "quality";
        field.Type = TType.Byte;
        field.ID = 60;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Quality);
        oprot.WriteFieldEnd();
      }
      if (SkillInfoList != null && __isset.skillInfoList) {
        field.Name = "skillInfoList";
        field.Type = TType.List;
        field.ID = 70;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, SkillInfoList.Count));
          foreach (SkillInfo _iter3 in SkillInfoList)
          {
            _iter3.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.loyalty) {
        field.Name = "loyalty";
        field.Type = TType.I32;
        field.ID = 100;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Loyalty);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("HeroInfo(");
      sb.Append("TemplateId: ");
      sb.Append(TemplateId);
      sb.Append(",UniqueId: ");
      sb.Append(UniqueId);
      sb.Append(",Level: ");
      sb.Append(Level);
      sb.Append(",Exp: ");
      sb.Append(Exp);
      sb.Append(",Star: ");
      sb.Append(Star);
      sb.Append(",Quality: ");
      sb.Append(Quality);
      sb.Append(",SkillInfoList: ");
      sb.Append(SkillInfoList);
      sb.Append(",Loyalty: ");
      sb.Append(Loyalty);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
