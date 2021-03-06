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
  public partial class SCSystemInfoMsg : TBase
  {

    public NetFramework.Auto.SystemInfo SystemInfo { get; set; }

    public SCSystemInfoMsg() {
    }

    public SCSystemInfoMsg(NetFramework.Auto.SystemInfo systemInfo) : this() {
      this.SystemInfo = systemInfo;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_systemInfo = false;
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
            if (field.Type == TType.Struct) {
              SystemInfo = new NetFramework.Auto.SystemInfo();
              SystemInfo.Read(iprot);
              isset_systemInfo = true;
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
      if (!isset_systemInfo)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SCSystemInfoMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "systemInfo";
      field.Type = TType.Struct;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      SystemInfo.Write(oprot);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCSystemInfoMsg(");
      sb.Append("SystemInfo: ");
      sb.Append(SystemInfo== null ? "<null>" : SystemInfo.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
