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
  public partial class SCAddPropsMsg : TBase
  {
    private NetFramework.Auto.PropsInfo _propsInfo;

    public NetFramework.Auto.PropsInfo PropsInfo
    {
      get
      {
        return _propsInfo;
      }
      set
      {
        __isset.propsInfo = true;
        this._propsInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool propsInfo;
    }

    public SCAddPropsMsg() {
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
              PropsInfo = new NetFramework.Auto.PropsInfo();
              PropsInfo.Read(iprot);
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
      TStruct struc = new TStruct("SCAddPropsMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PropsInfo != null && __isset.propsInfo) {
        field.Name = "propsInfo";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        PropsInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCAddPropsMsg(");
      sb.Append("PropsInfo: ");
      sb.Append(PropsInfo== null ? "<null>" : PropsInfo.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
