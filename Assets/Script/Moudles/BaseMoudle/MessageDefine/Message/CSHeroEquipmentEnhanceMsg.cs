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
  public partial class CSHeroEquipmentEnhanceMsg : TBase
  {
    private NetFramework.Auto.HeroEquipmentEnhanceType _enhanceType;
    private long _equipmentUniqueId;

    /// <summary>
    /// 
    /// <seealso cref="NetFramework.Auto.HeroEquipmentEnhanceType"/>
    /// </summary>
    public NetFramework.Auto.HeroEquipmentEnhanceType EnhanceType
    {
      get
      {
        return _enhanceType;
      }
      set
      {
        __isset.enhanceType = true;
        this._enhanceType = value;
      }
    }

    public long EquipmentUniqueId
    {
      get
      {
        return _equipmentUniqueId;
      }
      set
      {
        __isset.equipmentUniqueId = true;
        this._equipmentUniqueId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool enhanceType;
      public bool equipmentUniqueId;
    }

    public CSHeroEquipmentEnhanceMsg() {
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
              EnhanceType = (NetFramework.Auto.HeroEquipmentEnhanceType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I64) {
              EquipmentUniqueId = iprot.ReadI64();
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
      TStruct struc = new TStruct("CSHeroEquipmentEnhanceMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.enhanceType) {
        field.Name = "enhanceType";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)EnhanceType);
        oprot.WriteFieldEnd();
      }
      if (__isset.equipmentUniqueId) {
        field.Name = "equipmentUniqueId";
        field.Type = TType.I64;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(EquipmentUniqueId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSHeroEquipmentEnhanceMsg(");
      sb.Append("EnhanceType: ");
      sb.Append(EnhanceType);
      sb.Append(",EquipmentUniqueId: ");
      sb.Append(EquipmentUniqueId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
