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
  public partial class BattleLifeInfo : TBase
  {
    private long _uniqueId;
    private int _rage;

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

    public int Rage
    {
      get
      {
        return _rage;
      }
      set
      {
        __isset.rage = true;
        this._rage = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool uniqueId;
      public bool rage;
    }

    public BattleLifeInfo() {
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
              UniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              Rage = iprot.ReadI32();
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
      TStruct struc = new TStruct("BattleLifeInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.uniqueId) {
        field.Name = "uniqueId";
        field.Type = TType.I64;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(UniqueId);
        oprot.WriteFieldEnd();
      }
      if (__isset.rage) {
        field.Name = "rage";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Rage);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("BattleLifeInfo(");
      sb.Append("UniqueId: ");
      sb.Append(UniqueId);
      sb.Append(",Rage: ");
      sb.Append(Rage);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
