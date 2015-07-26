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
  public partial class SendChatCharInfo : TBase
  {
    private int _sendCharId;
    private string _charName;
    private sbyte _vipLevel;

    public int SendCharId
    {
      get
      {
        return _sendCharId;
      }
      set
      {
        __isset.sendCharId = true;
        this._sendCharId = value;
      }
    }

    public string CharName
    {
      get
      {
        return _charName;
      }
      set
      {
        __isset.charName = true;
        this._charName = value;
      }
    }

    public sbyte VipLevel
    {
      get
      {
        return _vipLevel;
      }
      set
      {
        __isset.vipLevel = true;
        this._vipLevel = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool sendCharId;
      public bool charName;
      public bool vipLevel;
    }

    public SendChatCharInfo() {
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
              SendCharId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.String) {
              CharName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Byte) {
              VipLevel = iprot.ReadByte();
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
      TStruct struc = new TStruct("SendChatCharInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.sendCharId) {
        field.Name = "sendCharId";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SendCharId);
        oprot.WriteFieldEnd();
      }
      if (CharName != null && __isset.charName) {
        field.Name = "charName";
        field.Type = TType.String;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CharName);
        oprot.WriteFieldEnd();
      }
      if (__isset.vipLevel) {
        field.Name = "vipLevel";
        field.Type = TType.Byte;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(VipLevel);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SendChatCharInfo(");
      sb.Append("SendCharId: ");
      sb.Append(SendCharId);
      sb.Append(",CharName: ");
      sb.Append(CharName);
      sb.Append(",VipLevel: ");
      sb.Append(VipLevel);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
