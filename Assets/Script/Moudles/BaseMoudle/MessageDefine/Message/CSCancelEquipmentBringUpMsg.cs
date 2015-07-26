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
  public partial class CSCancelEquipmentBringUpMsg : TBase
  {
    private long _equipmentUniqueId;

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
      public bool equipmentUniqueId;
    }

    public CSCancelEquipmentBringUpMsg() {
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
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("CSCancelEquipmentBringUpMsg");
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
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSCancelEquipmentBringUpMsg(");
      sb.Append("EquipmentUniqueId: ");
      sb.Append(EquipmentUniqueId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
