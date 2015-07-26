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
  public partial class SCExitArmyMsg : TBase
  {
    private NetFramework.Auto.SystemInfo _failSystemInfo;

    public NetFramework.Auto.SystemInfo FailSystemInfo
    {
      get
      {
        return _failSystemInfo;
      }
      set
      {
        __isset.failSystemInfo = true;
        this._failSystemInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool failSystemInfo;
    }

    public SCExitArmyMsg() {
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
            if (field.Type == TType.Struct) {
              FailSystemInfo = new NetFramework.Auto.SystemInfo();
              FailSystemInfo.Read(iprot);
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
      TStruct struc = new TStruct("SCExitArmyMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (FailSystemInfo != null && __isset.failSystemInfo) {
        field.Name = "failSystemInfo";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        FailSystemInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCExitArmyMsg(");
      sb.Append("FailSystemInfo: ");
      sb.Append(FailSystemInfo== null ? "<null>" : FailSystemInfo.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
