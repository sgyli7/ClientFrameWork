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
  public partial class SendChatTeamInfo : TBase
  {
    private int _teamId;

    public int TeamId
    {
      get
      {
        return _teamId;
      }
      set
      {
        __isset.teamId = true;
        this._teamId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool teamId;
    }

    public SendChatTeamInfo() {
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
              TeamId = iprot.ReadI32();
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
      TStruct struc = new TStruct("SendChatTeamInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.teamId) {
        field.Name = "teamId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TeamId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SendChatTeamInfo(");
      sb.Append("TeamId: ");
      sb.Append(TeamId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
