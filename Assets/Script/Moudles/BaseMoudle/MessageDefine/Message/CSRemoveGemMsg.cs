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
  public partial class CSRemoveGemMsg : TBase
  {
    private long _equipmentUniqueId;
    private sbyte _holeIndex;

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

    public sbyte HoleIndex
    {
      get
      {
        return _holeIndex;
      }
      set
      {
        __isset.holeIndex = true;
        this._holeIndex = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool equipmentUniqueId;
      public bool holeIndex;
    }

    public CSRemoveGemMsg() {
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
              EquipmentUniqueId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Byte) {
              HoleIndex = iprot.ReadByte();
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
      TStruct struc = new TStruct("CSRemoveGemMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.equipmentUniqueId) {
        field.Name = "equipmentUniqueId";
        field.Type = TType.I64;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(EquipmentUniqueId);
        oprot.WriteFieldEnd();
      }
      if (__isset.holeIndex) {
        field.Name = "holeIndex";
        field.Type = TType.Byte;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(HoleIndex);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSRemoveGemMsg(");
      sb.Append("EquipmentUniqueId: ");
      sb.Append(EquipmentUniqueId);
      sb.Append(",HoleIndex: ");
      sb.Append(HoleIndex);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
