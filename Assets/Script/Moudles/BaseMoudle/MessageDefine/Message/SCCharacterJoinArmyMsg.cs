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
  public partial class SCCharacterJoinArmyMsg : TBase
  {
    private NetFramework.Auto.ArmyMemberInfo _memberInfo;

    public NetFramework.Auto.ArmyMemberInfo MemberInfo
    {
      get
      {
        return _memberInfo;
      }
      set
      {
        __isset.memberInfo = true;
        this._memberInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool memberInfo;
    }

    public SCCharacterJoinArmyMsg() {
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
              MemberInfo = new NetFramework.Auto.ArmyMemberInfo();
              MemberInfo.Read(iprot);
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
      TStruct struc = new TStruct("SCCharacterJoinArmyMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (MemberInfo != null && __isset.memberInfo) {
        field.Name = "memberInfo";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        MemberInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCCharacterJoinArmyMsg(");
      sb.Append("MemberInfo: ");
      sb.Append(MemberInfo== null ? "<null>" : MemberInfo.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
