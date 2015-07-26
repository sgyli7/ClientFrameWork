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
  public partial class SCTickAuraMsg : TBase
  {
    private long _userUniqueId;
    private List<long> _affectUniqueIdList;
    private int _auraId;
    private int _skillId;

    public long UserUniqueId
    {
      get
      {
        return _userUniqueId;
      }
      set
      {
        __isset.userUniqueId = true;
        this._userUniqueId = value;
      }
    }

    public List<long> AffectUniqueIdList
    {
      get
      {
        return _affectUniqueIdList;
      }
      set
      {
        __isset.affectUniqueIdList = true;
        this._affectUniqueIdList = value;
      }
    }

    public int AuraId
    {
      get
      {
        return _auraId;
      }
      set
      {
        __isset.auraId = true;
        this._auraId = value;
      }
    }

    /// <summary>
    /// 由使用者的哪个技能触发的
    /// </summary>
    public int SkillId
    {
      get
      {
        return _skillId;
      }
      set
      {
        __isset.skillId = true;
        this._skillId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool userUniqueId;
      public bool affectUniqueIdList;
      public bool auraId;
      public bool skillId;
    }

    public SCTickAuraMsg() {
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
            if (field.Type == TType.I64) {
              UserUniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.List) {
              {
                AffectUniqueIdList = new List<long>();
                TList _list48 = iprot.ReadListBegin();
                for( int _i49 = 0; _i49 < _list48.Count; ++_i49)
                {
                  long _elem50 = 0;
                  _elem50 = iprot.ReadI64();
                  AffectUniqueIdList.Add(_elem50);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              AuraId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.I32) {
              SkillId = iprot.ReadI32();
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
      TStruct struc = new TStruct("SCTickAuraMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.userUniqueId) {
        field.Name = "userUniqueId";
        field.Type = TType.I64;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(UserUniqueId);
        oprot.WriteFieldEnd();
      }
      if (AffectUniqueIdList != null && __isset.affectUniqueIdList) {
        field.Name = "affectUniqueIdList";
        field.Type = TType.List;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, AffectUniqueIdList.Count));
          foreach (long _iter51 in AffectUniqueIdList)
          {
            oprot.WriteI64(_iter51);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.auraId) {
        field.Name = "auraId";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AuraId);
        oprot.WriteFieldEnd();
      }
      if (__isset.skillId) {
        field.Name = "skillId";
        field.Type = TType.I32;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SkillId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCTickAuraMsg(");
      sb.Append("UserUniqueId: ");
      sb.Append(UserUniqueId);
      sb.Append(",AffectUniqueIdList: ");
      sb.Append(AffectUniqueIdList);
      sb.Append(",AuraId: ");
      sb.Append(AuraId);
      sb.Append(",SkillId: ");
      sb.Append(SkillId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
