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
  public partial class CSChatSettingMsg : TBase
  {

    public NetFramework.Auto.ChatSettingInfo ChatSetting { get; set; }

    public CSChatSettingMsg() {
    }

    public CSChatSettingMsg(NetFramework.Auto.ChatSettingInfo chatSetting) : this() {
      this.ChatSetting = chatSetting;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_chatSetting = false;
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
              ChatSetting = new NetFramework.Auto.ChatSettingInfo();
              ChatSetting.Read(iprot);
              isset_chatSetting = true;
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
      if (!isset_chatSetting)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("CSChatSettingMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "chatSetting";
      field.Type = TType.Struct;
      field.ID = 10;
      oprot.WriteFieldBegin(field);
      ChatSetting.Write(oprot);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSChatSettingMsg(");
      sb.Append("ChatSetting: ");
      sb.Append(ChatSetting== null ? "<null>" : ChatSetting.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
