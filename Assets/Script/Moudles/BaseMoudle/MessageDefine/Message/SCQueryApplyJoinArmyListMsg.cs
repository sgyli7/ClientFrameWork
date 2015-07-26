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
  public partial class SCQueryApplyJoinArmyListMsg : TBase
  {
    private List<NetFramework.Auto.ApplyJoinArmyInfo> _applyJoinInfoList;

    public List<NetFramework.Auto.ApplyJoinArmyInfo> ApplyJoinInfoList
    {
      get
      {
        return _applyJoinInfoList;
      }
      set
      {
        __isset.applyJoinInfoList = true;
        this._applyJoinInfoList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool applyJoinInfoList;
    }

    public SCQueryApplyJoinArmyListMsg() {
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
            if (field.Type == TType.List) {
              {
                ApplyJoinInfoList = new List<NetFramework.Auto.ApplyJoinArmyInfo>();
                TList _list4 = iprot.ReadListBegin();
                for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                {
                  NetFramework.Auto.ApplyJoinArmyInfo _elem6 = new NetFramework.Auto.ApplyJoinArmyInfo();
                  _elem6 = new NetFramework.Auto.ApplyJoinArmyInfo();
                  _elem6.Read(iprot);
                  ApplyJoinInfoList.Add(_elem6);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("SCQueryApplyJoinArmyListMsg");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ApplyJoinInfoList != null && __isset.applyJoinInfoList) {
        field.Name = "applyJoinInfoList";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ApplyJoinInfoList.Count));
          foreach (NetFramework.Auto.ApplyJoinArmyInfo _iter7 in ApplyJoinInfoList)
          {
            _iter7.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCQueryApplyJoinArmyListMsg(");
      sb.Append("ApplyJoinInfoList: ");
      sb.Append(ApplyJoinInfoList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
