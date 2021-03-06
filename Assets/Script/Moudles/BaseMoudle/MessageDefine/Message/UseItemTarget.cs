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
  public partial class UseItemTarget : TBase
  {
    private long _uniqueId;
    private TargetType _targetType;

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

    /// <summary>
    /// 
    /// <seealso cref="TargetType"/>
    /// </summary>
    public TargetType TargetType
    {
      get
      {
        return _targetType;
      }
      set
      {
        __isset.targetType = true;
        this._targetType = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool uniqueId;
      public bool targetType;
    }

    public UseItemTarget() {
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
            if (field.Type == TType.I64) {
              UniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              TargetType = (TargetType)iprot.ReadI32();
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
      TStruct struc = new TStruct("UseItemTarget");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.uniqueId) {
        field.Name = "uniqueId";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(UniqueId);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetType) {
        field.Name = "targetType";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)TargetType);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UseItemTarget(");
      sb.Append("UniqueId: ");
      sb.Append(UniqueId);
      sb.Append(",TargetType: ");
      sb.Append(TargetType);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
